using UnityEngine;

public class DoJump : MonoBehaviour
{
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
