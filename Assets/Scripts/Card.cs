using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum CardType
{
    CreatureNormal,
    CreatureEffect,
    Spell,
    Trap
}

public enum CardAttributeType
{
    Wind,
    Earth,
    Fire,
    Water,
    Dark,
    Light,
    Trap,
    Spell
}


[CreateAssetMenu(fileName = "New Creature Normal Card", menuName = "Cards/Creature Normal Card")]
public class CreatureNormalCard : Card
{
    public CreatureNormalCard(int id, string cardName, int cost, int attack, int defense, string cardDescription)
        : base(id, cardName, cost, attack, defense, cardDescription)
    {
        // Add any additional initialization specific to CreatureNormalCard here
    }
}

[CreateAssetMenu(fileName = "New Creature Effect Card", menuName = "Cards/Creature Effect Card")]
public class CreatureEffectCard : Card
{
    public CreatureEffectCard(int id, string cardName, int cost, int attack, int defense, string cardDescription)
        : base(id, cardName, cost, attack, defense, cardDescription)
    {
        // Add any additional initialization specific to CreatureEffectCard here
    }
}

[CreateAssetMenu(fileName = "New Spell Card", menuName = "Cards/Spell Card")]
public class SpellCard : Card
{
    public SpellCard(int id, string cardName, int cost, int attack, int defense, string cardDescription)
        : base(id, cardName, cost, attack, defense, cardDescription)
    {
        // Add any additional initialization specific to SpellCard here
    }
}

[CreateAssetMenu(fileName = "New Trap Card", menuName = "Cards/Trap Card")]
public class TrapCard : Card
{
    public TrapCard(int id, string cardName, int cost, int attack, int defense, string cardDescription)
        : base(id, cardName, cost, attack, defense, cardDescription)
    {
        // Add any additional initialization specific to TrapCard here
    }
}

public class Card : ScriptableObject
{
    public int id;
    public string cardName;
    public Sprite artwork;
    public int cost;
    public int attack;
    public int defense;
    public string cardDescription;
    public CardAttributeType cardAttribute;
    public CardType cardType;
    public string typeDescription;

    public Card(int Id, string CardName, int Cost, int Attack, int Defense, string CardDescription)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        attack = Attack;
        defense = Defense;
        cardDescription = CardDescription;
    }
    
    // Public getter property to access cardBorders
    public Dictionary<CardType, Sprite> CardBorders => cardBorders;

    // Public getter property to access creatureCostImages
    public Dictionary<int, Sprite> CreatureCostImages => creatureCostImages;

    // Public getter property to access cardAttributeSymbols
    public Dictionary<CardAttributeType, Sprite> CardAttributeSymbols => cardAttributeSymbols;
    
    // Dictionary to map CardType to Border PNG
    private static Dictionary<CardType, Sprite> cardBorders = new Dictionary<CardType, Sprite>
    {
        { CardType.CreatureNormal, Resources.Load<Sprite>("BorderSprite/border_creature_normal") },
        { CardType.CreatureEffect, Resources.Load<Sprite>("BorderSprite/border_creature_effect") },
        { CardType.Spell, Resources.Load<Sprite>("BorderSprite/border_spell") },
        { CardType.Trap, Resources.Load<Sprite>("BorderSprite/border_trap") }
    };

    // Dictionary to map cost to Creature PNG
    private static Dictionary<int, Sprite> creatureCostImages = new Dictionary<int, Sprite>
    {
        { 1, Resources.Load<Sprite>("CreatureCostImages/cost1") },
        { 2, Resources.Load<Sprite>("CreatureCostImages/cost2") },
        { 3, Resources.Load<Sprite>("CreatureCostImages/cost3") },
        { 4, Resources.Load<Sprite>("CreatureCostImages/cost4") },
        { 5, Resources.Load<Sprite>("CreatureCostImages/cost5") },
        { 6, Resources.Load<Sprite>("CreatureCostImages/cost6") },
        { 7, Resources.Load<Sprite>("CreatureCostImages/cost7") },
        { 8, Resources.Load<Sprite>("CreatureCostImages/cost8") },
        { 9, Resources.Load<Sprite>("CreatureCostImages/cost9") },
        { 10, Resources.Load<Sprite>("CreatureCostImages/cost10") },
        { 11, Resources.Load<Sprite>("CreatureCostImages/cost11") },
        { 12, Resources.Load<Sprite>("CreatureCostImages/cost12") },
        { 13, Resources.Load<Sprite>("CreatureCostImages/cost13") }
    };

    // Dictionary to map CardAttribute to Attribute/Symbol PNG
    private static Dictionary<CardAttributeType, Sprite> cardAttributeSymbols = new Dictionary<CardAttributeType, Sprite>
    {
        { CardAttributeType.Wind, Resources.Load<Sprite>("AttributeSymbols/attribute_wind") },
        { CardAttributeType.Earth, Resources.Load<Sprite>("AttributeSymbols/attribute_earth") },
        { CardAttributeType.Fire, Resources.Load<Sprite>("AttributeSymbols/attribute_fire") },
        { CardAttributeType.Water, Resources.Load<Sprite>("AttributeSymbols/attribute_water") },
        { CardAttributeType.Light, Resources.Load<Sprite>("AttributeSymbols/attribute_light") },
        { CardAttributeType.Dark, Resources.Load<Sprite>("AttributeSymbols/attribute_dark") },
        { CardAttributeType.Spell, Resources.Load<Sprite>("AttributeSymbols/spell_symbol") },
        { CardAttributeType.Trap, Resources.Load<Sprite>("AttributeSymbols/trap_symbol") }
    };
}