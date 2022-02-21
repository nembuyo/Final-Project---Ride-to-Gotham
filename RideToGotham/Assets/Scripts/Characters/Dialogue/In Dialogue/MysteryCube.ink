INCLUDE Globals.Ink
{ convoTwo == true: -> ConversationTwo | -> main} 

== main == 

What is this place..? #speaker:Hal #portrait:Hal_Confused #layout:left
    * [It's not a dream, is it?] 
    I don't think I'd ask that if it was... #speaker:Hal #portrait:Hal_Sad #layout:left
    * [Where did Bruce go?]
    I need to find him. #speaker:Hal #portrait:Hal_Sad #layout:left
- I don't like being here. #speaker:Hal #portrait:Hal_Sad #layout:left
-> First_One
->END

== First_One == 
~ convoTwo = true
->END

==ConversationTwo ==
I really need to get out of here. #speaker:Hal #portrait:Hal_Sad #layout:left
 * [Is there a door somewhere?]
    I don't see one.. #speaker:Hal #portrait:Hal_Sad #layout:left
    I need to keep looking. #speaker:Hal #portrait:Hal_Neutral #layout:left
 * [I don't feel good.] #speaker:Hal #portrait:Hal_Sad #layout:left
    Ugh, I'm going to talk to Ion after this. #speaker:Hal #portrait:Hal_Angry #layout:left
- Find the door. #speaker:Hal #portrait:Hal_Angry #layout:left

->END
