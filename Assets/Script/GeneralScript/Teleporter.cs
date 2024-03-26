using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] Transform targetTransform;

    public void Teleport(Transform targetPoint)
    {
        targetTransform.position = targetPoint.position;
    }
}
