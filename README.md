# CS211-FinalProject

***Ultimate Goal*** (Not realistically attainable now but definitely can look forward to working on it as a hobby/passion project in the future): 

Build a Dungeon-Keeper Game that uses cards as a means for customizing features of a playable dungeon. Will basically require the functions of two separate games and then storing/interacting all the data in-between.

I figure that the project can go one of three ways:

The first way; I make the basis for at least one fundamental aspect of the game; whether it is the cards or the physical dungeon. 

The second way: I make the basis for both fundamental aspects of the game; the cards and the dungeon. 

The third way (The way I want it to go), I have the cards and the dungeon finished and then I do something cool that intertwines the two to start making the real game. I don't expect to have it finished in two weeks but I want to breathe life into the fundamental aspects of the gameplay.

***Goals (in order of what I expect to be the easiest to the hardest)***

***Difficulty Options: Easiest because I have done something like this before in the class, Harder because I am aware of helpful resources for building 3-D Dungeons but have never done it before, Hardest because I am unsure of how to make it work properly or efficiently***

Easiest Project Goal: Design a card game with a variety of unique cards and the potential for storing multiple decks.

**Step 1:** Build a card (Class function with unique representations of cards)

**Step 2:** Build Deck (Probably Dictionary data structure, maybe Unordered Map)

**Step 3:** Make functionality that allows players to "build" a deck put cards into it

**Step 4:** Allow players to shuffle and draw from the deck

Harder Project Goal: Build a 3-D Dungeon that a player can interact with freely and has the potential for letting the dungeonmaster interact with. 

**Step 1:** Build 3-D foundations for the dungeon in unity

**Step 2:** Add functions/functionality that allows the dungeon to be interacted with

**Step 3:** Build Player model in unity (basic features, probably from workshop, maybe custom)

**Step 4:** Add functions/functionality to play (movement, interactions)

Hardest Project Goal: Implementation of the game functionality with cards and the dungeon.

***Plan for game functionality***

1. *Turns*

  A. Dungeonmaster's First Turn
  
    i. Their Goal: Wants to stop the player from progressing
    
    ii. sets "Terrain" of dungeon with terrain cards
    
    iii. Dungeonmaster then place "triggers" in tiles on the floor
    
      a. Certain triggers have "synergies" with other triggers
      
      a. Loot spawns based off number of triggers (not directly-controlled by player).
      
  B. Player First Turn (always after dungeonmaster)
  
    i. Their Goal: To make it to next floor.
    
    ii. Can find loot along the way (encourages exploration)
    
    iii. Has to worry about traps and monsters taking down their health
    
      a. Can take advantage of tactics to overcome monster weaknesses and trap 
      
2. *Game Rules*

  A. The rules should be intuitive and promote clever strategies
  
    i. Have players draw card from deck into hand on each turn (limits cheese)
    
    ii. Each player progressively gains more power naturally and based off score.
    
      a. Awards good playstyles/combos.
      
    iii. Cards have mana values and/or limited interactivity (dragons cost a lot of mana, cant make impassable wall of     
        traps, etc.)
        
***Initial Ideas*** 

1. Implement a system with "Terrain" Cards with given parameters. 

The dungeonmaster can then choose which terrain card to "build" the dungeon. For example, a "Fire" type dungeon will have lava on the floor and geysers of water that trigger randomly. It will modify the monsters in this dungeon making them more aggressive with less defensive capabilities.

2. Implement a "turn-based trigger" system. 

At first, I thought that letting the dungeonmaster just plan their dungeon beforehand could be fun, but now I know I want the game to be interactive for the dungeonmaster in a way that juxtaposes how it is for the player. So, I decided that it would be cool to be to let the dungeonmaster place "triggers" before the player takes their turn. The dungeonmaster chooses a card from their deck that they want to place (the card be a trap, an item, a puzzle, a riddle, or a monster). After the dungeonmaster places the trigger cards then the player takes their turn and interacts with the dungeon. I think that this systemm will allow a back-and-forth strategy between the player and the dungeonmaster, the dungeonmaster wants to run combos with the cards they have to stop the player and the play wants to overcome the dungeon and get some sweet loot.

3. Implement "trigger" system. <--- I want to have this ready for presentation.

Establish the barebones version of the turn-based trigger system by making it possible for cards to "spawn" the triggers on thefloor.
