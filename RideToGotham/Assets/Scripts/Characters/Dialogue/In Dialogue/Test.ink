INCLUDE Globals.ink

{ hasBeenTalkedTo == true: -> Busy | -> main }

==main==
What is it, Hal? #speaker:Bruce #portrait:Bruce_Neutral #layout:left
    * [What are you doing?]
    I just called a boat, because I want to get out of here. #speaker:Bruce #portrait:Bruce_Neutral #layout:left
    Unlike someone else. #speaker:Bruce #portrait:Bruce_Neutral #layout:left
        ** [HEY!!] 
        It's not like I wanted my battery to run out! #speaker:Hal  #portrait:Hal_Angry  #layout:right
        You should've-- #speaker:Bruce #portrait:Bruce_Angry #layout:left
        Just go explore. #speaker:Bruce #portrait:Bruce_Neutral #layout:left
        -> Talked_to
     ** [I want to get out of here too!]
        I'm Sorry you're stuck here with me, I guess. #speaker:Hal  #portrait:Hal_Sad  #layout:right
        ...Just go explore.  #speaker:Bruce #portrait:Bruce_Sad #layout:left
        I'll tell you when the boat gets here.  #speaker:Bruce #portrait:Bruce_Neutral #layout:left
        -> Talked_to
->END
* [I'm bored.]
    How is that my fault? #speaker:Bruce #portrait:Bruce_Confused #layout:left
        * * [You're just standing there!]
            I'm trying to get us out of here, Hal. Go look around, maybe you'll find a way not to distract me. #speaker:Bruce #portrait:Bruce_Neutral #layout:left
            Ugh, fine. #speaker:Hal #portrait:Hal_Angry #layout:right
            -> DONE
            -> Talked_to
        * * [Uh, I guess it's not, but...]
            Listen, I'm busy right now. #speaker:Bruce #portrait:Bruce_Neutral #layout:left
            But I heard some frogs earlier, why don't you go find them? #speaker:Bruce  #portrait:Bruce_Happy #layout:left
            Sure, yeah. #portrait:Hal_Happy #speaker:Hal #layout:right
            Bye Bruce. #portrait:Hal_Happy #speaker:Hal #layout:right
            Have fun. #speaker:Bruce  #portrait:Bruce_Happy #layout:left
            -> Talked_to
->END

== Talked_to == 
~ hasBeenTalkedTo = true
-> END

== Busy == 

Bruce is a bit busy right now. #speaker:Bruce #portrait:Bruce_Neutral #layout:left
    *[Leave him be]
        He's just going to ignore me, anyway. #portrait:Hal_Sad #speaker:Hal #layout:right 
        -> DONE
    *[Stay until he pays attention]
        ... #portrait:Hal_Neutral #speaker:Hal #layout:right
        Yeah. he's ignoring me. #portrait:Hal_Angry #speaker:Hal #layout:right
        -> DONE
-> END