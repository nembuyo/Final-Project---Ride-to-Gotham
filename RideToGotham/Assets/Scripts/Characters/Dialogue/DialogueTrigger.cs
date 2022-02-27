using System.Collections;
using System.Collections.Generic;
using TMPro;
using Ink.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using Ink.UnityIntegration;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private AudioManager _audio;
    [SerializeField] private TextAsset inkJSON;
    public GameObject Prompter;
    [SerializeField] private bool prompterIsActive;

    private DialogueVariables dialogueVariables;
    [SerializeField] private InkFile globalsInkFile;
     
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private Animator spriteAnim;
    [SerializeField] private Animator layoutAnim;
    public GameObject choicesPanel;

    public Story currentStory;

    public bool dialogueIsPlaying;

    private const string SPEAKER_TAG = "speaker";
    private const string PORTRAIT_TAG = "portrait";
    private const string LAYOUT_TAG = "layout";


    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private void Awake()
    {
        dialogueVariables = new DialogueVariables(globalsInkFile.filePath);
    }


    private void Start()
    {
        _audio = AudioManager._instance;

        Prompter.SetActive(false);
        prompterIsActive = false;

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        choicesPanel.SetActive(false);

        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Prompter.SetActive(true);
            prompterIsActive = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Prompter.SetActive(false);
            prompterIsActive = false;
        }
    }

    public void EnterDialogueMode()
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        choicesPanel.SetActive(true);

        dialogueVariables.StartListening(currentStory);

        Prompter.SetActive(false);
        prompterIsActive = false;

        ContinueStory();
    }

    public void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if(currentChoices.Count > choices.Length)
        {
            Debug.LogError("Too many choice options!");
        }

        int index = 0;
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }
        StartCoroutine(SelectFirstChoice());
    }

    public void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();
            DisplayChoices();
            HandleTags(currentStory.currentTags);
        }
        else
        {
            ExitDialogueMode();
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        foreach (string tag in currentTags)
        {
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError($"Tag could not be parsed {tag}");
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            switch (tagKey)
            {
                case SPEAKER_TAG:
                    nameText.text = tagValue;
                    break;
                case PORTRAIT_TAG:
                    spriteAnim.Play(tagValue);
                    break;
                case LAYOUT_TAG:
                    layoutAnim.Play(tagValue);
                    break;
                default:
                    Debug.LogWarning($"Tag name does not match! {tag}");
                    break;
            }
        }
    }

    public IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }

    public void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";

        dialogueVariables.StopListening(currentStory);
    }


    private void Update()
    {
        if (prompterIsActive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _audio.Play("DialogueStart");
                Debug.Log("for the love of god");
                EnterDialogueMode();
            }
        }
    }
}
