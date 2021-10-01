using UnityEngine;
using DG.Tweening;

public class DoJump : MonoBehaviour
{
    public float animTime;
    public Ease ease;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            JumpTo(GetPositionToGo());
        }
    }

    private void JumpTo(Vector3 point)
    {
        transform
            .DOJump(point, 2, 1, animTime)
            .SetEase(ease)
            .OnComplete(() =>
            {
                Debug.Log("Pulamoss");
            });
    }

    private Vector3 GetPositionToGo()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Cache this Camera.main for better performance
        RaycastHit hit;

        int floorLayerMask = 6; // Create a Layer Mask Floor and set here
        floorLayerMask = ~floorLayerMask;

        if (Physics.Raycast(ray, out hit, 100, floorLayerMask))
            return hit.point;

        return Vector3.zero;
    }
}
