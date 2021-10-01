using UnityEngine;

using DG.Tweening;

public class ButtonFade : MonoBehaviour
{
    public CanvasGroup group;
    public float fadeTime;

    private void Start()
    {
        Fade(0);
    }

    public void Fade(float i)
    {
        group.DOFade(i, fadeTime);
    }
}
