using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, 0, "None"));
        cardList.Add(new Card(1, "Seven Road Magician", 7, 2100, 1500, "[Requirement] Send the top card of your Deck to the Graveyard\n[Effect] This card gains ATK equal to [the number of different Attributes in your Graveyard] x 300. until the end of this turn"));
        cardList.Add(new Card(2, "Torna the Windweaver", 6, 1600, 1000, "[Requirement] Send 1 card from your hand to the Graveyard\n[Effect] Change the battle position of 1 monster on your opponent's field (Attack Position becomes face-up Defense Position, Defense Position becomes face-up Attack Position)"));
    }
}