using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI defenseText;
    public Image artworkImage;
    public Image attributeSymbolImage;
    public Image borderImage;
    public Image costImage;
    public Image extraStatbar;

    void Start()
    {
        if (card != null)
        {
            nameText.text = card.cardName;
            descriptionText.text = card.cardDescription;
            artworkImage.sprite = card.artwork;
            typeText.text = card.typeDescription;
            attackText.text = card.attack.ToString();
            defenseText.text = card.defense.ToString();

            if (card.cardType == CardType.CreatureNormal || card.cardType == CardType.CreatureEffect ||
                card.cardType == CardType.Spell || card.cardType == CardType.Trap)
            {
                // Get the corresponding PNG based on the card's type (creature or spell/trap) from the cardBorders dictionary
                if (card.CardBorders.TryGetValue(card.cardType, out Sprite borderSprite))
                {
                    borderImage.sprite = borderSprite;
                }

                // Get the corresponding PNG based on the card's attribute from the cardAttributeSymbols dictionary
                if (card.CardAttributeSymbols.TryGetValue(card.cardAttribute, out Sprite attributeSprite))
                {
                    // Display the attribute symbol for creature cards
                    attributeSymbolImage.sprite = attributeSprite;
                    attributeSymbolImage.gameObject.SetActive(true);
                }
                else
                {
                    // Hide the attribute symbol for non-creature cards
                    attributeSymbolImage.gameObject.SetActive(false);
                }

                // Get the corresponding PNG based on the card's cost from the creatureCostImages dictionary
                if (card.CreatureCostImages.TryGetValue(card.cost, out Sprite costSprite))
                {
                    // Display the cost symbol for creature and spell/trap cards
                    costImage.sprite = costSprite;
                    costImage.gameObject.SetActive(true);
                }
                else
                {
                    // Hide the cost symbol for cards without a cost (e.g., Spell, Trap)
                    costImage.gameObject.SetActive(false);
                }

                // Show the border image for creature and spell/trap cards
                borderImage.gameObject.SetActive(true);
            }
            else
            {
                // Hide any symbols and border for other card types (e.g., Spell, Trap, etc.)
                attributeSymbolImage.gameObject.SetActive(false);
                costImage.gameObject.SetActive(false);
                borderImage.gameObject.SetActive(false);
            }
        
            if (card.cardType == CardType.CreatureNormal || card.cardType == CardType.CreatureEffect)
            {
                extraStatbar.gameObject.SetActive(true);
                attackText.gameObject.SetActive(true);
                defenseText.gameObject.SetActive(true);
                costImage.gameObject.SetActive(true);
            }
            else
            {
                extraStatbar.gameObject.SetActive(false);
                attackText.gameObject.SetActive(false);
                defenseText.gameObject.SetActive(false);
                costImage.gameObject.SetActive(false);
            }
        }
    }
}