using UnityEngine;

using DG.Tweening;

public class GrabCoin : MonoBehaviour
{
    [SerializeField] private RectTransform toGo;
    [SerializeField] private float animTime;

    [SerializeField] private Ease ease;

    private void OnMouseDown()
    {
        Vector3 realPosition = Camera.main.ScreenToWorldPoint(toGo.position);

        transform
            .DOMove(realPosition, animTime)
            .SetEase(ease)
            .OnComplete(() => { Destroy(gameObject); });
    }
}
