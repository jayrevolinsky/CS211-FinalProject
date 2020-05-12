# Read Me-CS211 Final Project

## _Special Instructions_

**_1. The game has text tutorials on the UI_**

## _Known Problems with GamePlay_

_The code compiles so these problems currently affect just gameplay_
_This is more like a TO-DO list_

1. When going between scenes CardFunctions resets the value for the MonsterList, so it just spawns Skeletons which are Element 0 on the MonsterList.
    - likely an issue with MonoBehavior
2. The Keeper has a player inventory
    - Not necessarily an issue because I have yet to decide to design it more or disable it.
3. The "Keeper" can currently spawn in as many Monsters as Unity can handle.
    - need to implement a "mana" or "spell slot" system.
4. Monsters spawned in the Keeper Scene are not saved in the scene with player.
    - maybe DontDestroyOnLoad can help, I tie this issue with 1 but it's big enough to not be a 1a.
5. Monsters spawn in only a single location, despite the GridPlacement script working for PrimitiveType objects (Cubes).
    - likely a problem with the enemy script
6. The Player is unable to attack the Monster, meaning that the monster will chase the player around and kill them while the player
    has to avoid the invulnerable monster.
    - Likely a problem with Gizmos, going to have to look over Enemy script.
7. Inventory Slots are not saved between scenes.
    - Same issue as monsters, requires me learning more.
