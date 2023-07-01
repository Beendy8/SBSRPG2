using UnityEngine;
using UnityEngine.Events;

public class MoveToPoint : MonoBehaviour
{
    [SerializeField] private Transform targetPoint;
    [SerializeField] private float speed = 1;
    [SerializeField] private UnityEvent onFinish;
    [SerializeField] private Transform transformParent;

    private void Update()
    {
        Move();
    }
    public void Move()
    {
        transformParent.position = Vector3.MoveTowards(transformParent.position, targetPoint.position, speed * Time.deltaTime);

        if (transformParent.position == targetPoint.position)
            onFinish.Invoke();
    }

}