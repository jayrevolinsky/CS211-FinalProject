using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>(); //create list for cards

    public void Awake() //when game starts build cards
    {
        cardList.Add(new Card(0, "Card1", 0, "NoType", "NoDescription")); //add card data
        cardList.Add(new Card(1, "Card2", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(2, "Card3", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(3, "Card4", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(4, "Card5", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(5, "Card6", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(6, "Card7", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(7, "Card8", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(8, "Card9", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(9, "Card10", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(10, "Card11", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(11, "Card12", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(12, "Card13", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(13, "Card14", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(14, "Card15", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(15, "Card16", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(16, "Card17", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(17, "Card18", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(18, "Card19", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(19, "Card20", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(20, "Card21", 0, "NoType", "NoDescription"));
        cardList.Add(new Card(21, "Card22", 0, "NoType", "NoDescription"));
    }
}
