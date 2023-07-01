using UnityEngine;
using UnityEngine.Events;

public class DistanceTrigger : MonoBehaviour
{
    [SerializeField] private Transform targetPoint;
    [SerializeField] private float distanceThreshold;
    [SerializeField] private UnityEvent onTrigger;

    private void Update()
    {
        float distance = Vector2.Distance(targetPoint.position, transform.position);

        if (distance <= distanceThreshold)
        {
            onTrigger.Invoke();
        }

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, distanceThreshold);
    }
}
