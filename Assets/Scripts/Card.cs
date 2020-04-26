using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int _CardID; //identifier label of card
    public string _CardName; //name of card
    public int _CardMana;  //mana cost of card
    public string _CardType; //damage type of card
    public string _CardDescription; //written description of card effect

    //constructor for card variables
    public Card(int CardID, string CardName, int CardMana, string CardType, string CardDescription)
    {
        _CardID = CardID;
        _CardName = CardName;
        _CardMana = CardMana;
        _CardType = CardType;
        _CardDescription = CardDescription;
    }
}
