using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DrawnCard : MonoBehaviour
{
    public Card card;

    public Text NameText;
    public Text ManaText;
    public Text PrimaryTypeColor;
    public Text SecondaryTypeColor;
    public Text DescriptionText;
    public Image CardImage;

    private void Start()
    {
        NameText.text = card.name;
        DescriptionText.text = card._CardDescription;

        CardImage.sprite = card._CardArtwork;

        ManaText.text = card._CardMana.ToString();
        PrimaryTypeColor.text = card._CardPrimaryType.ToString();
        SecondaryTypeColor.text = card._CardSecondaryType.ToString();
    }
    //public List<Card> _DrawnCard = new List<Card>();
    //public int _DrawnID;

    //public int CardID;
    //public string CardName;
    //public int CardMana;
    //public string CardPrimaryType;
    //public string CardSecondaryType;
    //public string CardDescription;

    //void Start()
    //{
    //    _DrawnCard[0] = CardDatabase.cardList[_DrawnID];
    //}
    //void Update()
    //{
    //    CardID = _DrawnCard[0]._CardID;
    //    CardName = _DrawnCard[0]._CardName;
    //    CardMana = _DrawnCard[0]._CardMana;
    //    CardPrimaryType = _DrawnCard[0]._CardPrimaryType;
    //    CardSecondaryType = _DrawnCard[0]._CardSecondaryType;
    //    CardDescription = _DrawnCard[0]._CardDescription;

    //    NameText.text = "" + CardName;
    //    ManaText.text = "" + CardMana;
    //    PrimaryTypeColor.text = "" + CardPrimaryType;
    //    SecondaryTypeColor.text = "" + CardSecondaryType;
    //    DescriptionText.text = "" + CardDescription;

    //}
}
