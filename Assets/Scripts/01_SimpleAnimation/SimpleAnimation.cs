using UnityEngine;

using DG.Tweening;

public class SimpleAnimation : MonoBehaviour
{
    [SerializeField] private Transform objTransform;
    [SerializeField] private float animTime;

    [SerializeField] private Ease ease;

    private void Start()
    {
        objTransform
            .DOMoveY(2.33f, animTime)
            .SetEase(ease)
            .SetLoops(-1, LoopType.Yoyo)
            .OnStepComplete(Debuggar);
    }

    void Debuggar()
    {
        Debug.Log("Funcionouuuu");
    }
}
