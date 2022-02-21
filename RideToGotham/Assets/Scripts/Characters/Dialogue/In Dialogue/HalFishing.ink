INCLUDE Globals.Ink
-> main

==main==
@ -8,5 +9,10 @@ Hey, what's this? #speaker:Hal #portrait:Hal_Happy #layout:right
    * [Bruce did say I should explore...] #speaker:Hal #portrait:Hal_Happy #layout:right
        ... #speaker:Hal #portrait:Hal_Neutral #layout:right
        So why not take it? #speaker:Hal #portrait:Hal_Happy2 #layout:right
- [You have the Fishing Rod now! Go to the dock and press C to fish! (Right now it's just one fish model/type, but it's mostly to relax. this is a demo!)] #speaker:Hal #portrait:Hal_Happy #layout:right
- [You have the Fishing Rod now! Go to the dock and interact with the box to fish!] #speaker:Hal #portrait:Hal_Happy #layout:right
    -> fishingRod

== fishingRod ==
~ hasFishingPole = true
-> END