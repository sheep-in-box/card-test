using System.Collections.Generic;
using UnityEngine;

public class TestSystem : MonoBehaviour
{
    // [SerializeField] private HandView handView;
    [SerializeField] private List<CardData> deckData;
    private void Start()
    {
        CardSystem.Instance.Setup(deckData);
    }

    // // void Start()
    // // {
    // //     CardView cardView = CardViewCreator.Instance.CreateCardView(Vector3.zero, Quaternion.identity);
    // //     StartCoroutine(handView.AddCard(cardView));
    // // }
    // private void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         Card card = new(cardData);
    //         CardView cardView = CardViewCreator.Instance.CreateCardView(card, Vector3.zero, Quaternion.identity);
    //         StartCoroutine(handView.AddCard(cardView));
    //     }
    // }
}
