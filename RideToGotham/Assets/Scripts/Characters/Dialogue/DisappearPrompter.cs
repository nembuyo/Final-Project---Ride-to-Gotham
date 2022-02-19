using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearPrompter : MonoBehaviour
{
    [SerializeField] private DialogueTrigger diaTrig;
    //amongst other things....
    private void OnCollisionExit(Collision collision)
    {
        diaTrig.Prompter.SetActive(false);
        diaTrig.choicesPanel.SetActive(false);
    }

}
