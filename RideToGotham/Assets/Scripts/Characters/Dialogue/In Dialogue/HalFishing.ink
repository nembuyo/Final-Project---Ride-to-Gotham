INCLUDE Globals.Ink
-> main

==main==
Hey, what's this? #speaker:Hal #portrait:Hal_Happy #layout:right
    * [An old fishing rod, I think.] #speaker:Hal #portrait:Hal_Happy #layout:right
        ... #speaker:Hal #portrait:Hal_Neutral #layout:right
        The old owners won't mind if I take it, right? #speaker:Hal #portrait:Hal_Happy2 #layout:right
    * [Bruce did say I should explore...] #speaker:Hal #portrait:Hal_Happy #layout:right
        ... #speaker:Hal #portrait:Hal_Neutral #layout:right
        So why not take it? #speaker:Hal #portrait:Hal_Happy2 #layout:right
- [You have the Fishing Rod now! Go to the dock and interact with the box to fish!] #speaker:Hal #portrait:Hal_Happy #layout:right
    -> fishingRod

== fishingRod ==
~ hasFishingPole = true

->END