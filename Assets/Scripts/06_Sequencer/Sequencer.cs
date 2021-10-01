using UnityEngine;

using DG.Tweening;

public class Sequencer : MonoBehaviour
{
    [SerializeField] private Transform objTransform;
    [SerializeField] private float animTime;

    private void Start()
    {
        Sequence sequencer = DOTween.Sequence();

        //sequencer.Pause();

        sequencer.Append(objTransform.DOMoveX(3f, animTime));
        sequencer.Append(objTransform.DOMoveY(2f, animTime));
        sequencer.AppendInterval(2f);
        sequencer.Append(objTransform.DOShakeScale(animTime, 1, 10, 90, true));
        sequencer.Prepend(objTransform.DOMoveX(5f, animTime));

        //sequencer.Play();
    }
}
