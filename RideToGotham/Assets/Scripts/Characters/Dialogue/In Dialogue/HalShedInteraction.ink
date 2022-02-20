INCLUDE Globals.Ink

{ hasFishingPole == true: -> HasFishingRod | -> main}

==main== 
Hmm, this place seems abandoned. #speaker:Hal #portrait:Hal_Neutral #layout:right
    * [There's some fishing stuff there, too... ]
    I wonder if there's more stuff nearby! #speaker:Hal #portrait:Hal_Happy2 #layout:right
    -> END
    * [I don't think I can go in, the door is locked and the key thing isn't there.]
        Seems like someone doesn't want anyone finding out their secrets. #speaker:Hal #portrait:Hal_Happy #layout:right
    -> END
-> END

== HasFishingRod == 
Hmm, this place seems abandoned. #speaker:Hal #portrait:Hal_Neutral #layout:right
    * [There's some fishing stuff there, too... ]
    I hope they don't mind I took their fishing rod... #speaker:Hal #portrait:Hal_Happy #layout:right
    -> END
    * [I don't think I can go in, the door is locked and the key thing isn't there.]
        Seems like someone doesn't want anyone finding out their secrets. #speaker:Hal #portrait:Hal_Happy #layout:right
-> END

