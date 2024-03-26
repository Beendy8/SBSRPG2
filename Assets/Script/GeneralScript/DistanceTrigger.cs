using UnityEngine;
using UnityEngine.Events;

public class DistanceTrigger : MonoBehaviour
{
    [SerializeField] private float distanceThreshold;
    [SerializeField] private UnityEvent onTrigger;
    [SerializeField] Transform transform1;
    [SerializeField] Transform transform2;

    private void Update()
    {
        float distance = Vector2.Distance(transform1.position, transform2.position);

        if (distance <= distanceThreshold)
            onTrigger.Invoke();
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, distanceThreshold);
    }
}
