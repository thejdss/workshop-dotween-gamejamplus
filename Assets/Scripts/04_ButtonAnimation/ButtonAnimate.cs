using UnityEngine;

using DG.Tweening;

public class ButtonAnimate : MonoBehaviour
{
    public Transform startpos;
    public Transform button_one;
    public Transform button_two;

    public Vector3 button_one_go;
    public Vector3 button_two_go;

    public float animTime;

    public Ease ease;

    public bool isOpen = true;

    public void OpenCloseMenu()
    {
        if (isOpen)
        {
            button_one.DOMove(startpos.transform.position, animTime).SetEase(ease);
            button_two.DOMove(startpos.transform.position, animTime).SetEase(ease);
        }
        else
        {
            button_one.DOMove(button_one.transform.position + button_one_go, animTime).SetEase(ease);
            button_two.DOMove(button_two.transform.position + button_two_go, animTime).SetEase(ease);
        }

        isOpen = !isOpen;
    }
}
