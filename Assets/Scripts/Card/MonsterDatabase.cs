using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class MonsterDatabase : MonoBehaviour
{
    public List<GameObject> monsterDatabase;
    public void Awake() //when game starts build cards
    {
        //MonsterList.Add(new Card(0, "Skeleton", 1, "Monster", "Undead", "Rattles a lot"));
        //MonsterList.Add(new Card(1, "Abomination", 4, "Monster", "Undead", "Large, Loud, and Angry"));
        //MonsterList.Add(new Card(2, "Bone Golem", 6, "Monster", "Undead", "Watch the pointy bits"));

    }
}
