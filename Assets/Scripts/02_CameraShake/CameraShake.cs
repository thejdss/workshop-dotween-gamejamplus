using UnityEngine;

using DG.Tweening;

public class CameraShake : MonoBehaviour
{
    public Transform cam;

    private void Start()
    {
        cam = Camera.main.transform;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShakeCamera();
        }
    }

    private void ShakeCamera()
    {
        cam.DOShakePosition(4f, 1, 10, 90, false, true);
    }
}
