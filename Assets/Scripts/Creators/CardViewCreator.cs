using DG.Tweening;
using UnityEngine;

public class CardViewCreator : Singleton<CardViewCreator>
{
    [SerializeField] private CardView cardViewPrefab;
    public CardView CreateCardView(Card card, Vector3 position, Quaternion rotation)
    {
        CardView newCardView = Instantiate(cardViewPrefab, position, rotation);
        newCardView.transform.localScale = Vector3.zero;
        newCardView.transform.DOScale(Vector3.one, 0.15f)
            .SetEase(Ease.OutBack)
            .OnComplete(() => newCardView.transform.localScale = Vector3.one); // Ensure scale is set to one after animation
        newCardView.Setup(card);
        return newCardView;
    }
}
