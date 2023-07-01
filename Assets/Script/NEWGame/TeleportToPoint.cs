using UnityEngine;

public class TeleportToPoint : MonoBehaviour
{
    [SerializeField] private Transform teleportPoint;

    public void Teleport()
    {
        transform.position = teleportPoint.position;
    }
}
