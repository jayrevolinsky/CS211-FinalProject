using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int _CardID; //identifier label of card
    public string _CardName; //name of card
    public int _CardMana;  //mana cost of card
    public string _CardPrimaryType; //type of card
    public string _CardSecondaryType; //damage type of card

    public Color MonsterPrimaryType = new  Color(1.0f, 0.0f, 0.0f, 1.0f); //red
    public Color SpellPrimaryType = new Color(0.0f, 0.0f, 1.0f, 1.0f); //blue
    public Color TerrainPrimaryType = new Color(1.0f, 0.92f, 0.016f, 1.0f); //yellow

    public string _CardDescription; //written description of card effect

    //constructor for card variables
    public Card(int CardID, string CardName, int CardMana, string CardPrimaryType, string CardSecondaryType, string CardDescription)
    {
        _CardID = CardID;
        _CardName = CardName;
        _CardMana = CardMana;
        _CardPrimaryType = CardPrimaryType;
        _CardSecondaryType = CardSecondaryType;
        _CardDescription = CardDescription;
    }
}
