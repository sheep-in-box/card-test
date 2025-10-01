using UnityEngine;

public class Card
{
    public string Title => _data.name;
    public string Description => _data.Description;
    public Sprite Image => _data.Image;
    public int Mana {get; private set; } = 0;
    private readonly CardData _data;
    public Card(CardData data)
    {
        _data = data;
        Mana = data.Maga;
    }
}
