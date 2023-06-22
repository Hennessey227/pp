using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedCameraFollower : MonoBehaviour
{

    public GameObject MainCamera;
    private struct PointInSpace
    {
        public Vector3 Position;
        public float Time;
    }

    [SerializeField]
    [Tooltip("The transform to follow")]
    private Transform target;

    [SerializeField]
    [Tooltip("The offset between the target and the camera")]
    private Vector3 offset;

    [Tooltip("The delay before the camera starts to follow the target")]
    [SerializeField]
    private float delay = 0.5f;

    [SerializeField]
    [Tooltip("The speed used in the lerp function when the camera follows the target")]
    private float speed = 5;

    
    private Queue<PointInSpace> pointsInSpace = new Queue<PointInSpace>();

    void LateUpdate()
    {
        
        pointsInSpace.Enqueue(new PointInSpace() { Position = target.position, Time = Time.time });

        
        while (pointsInSpace.Count > 0 && pointsInSpace.Peek().Time <= Time.time - delay + Mathf.Epsilon)
        {
            transform.position = Vector3.Lerp(transform.position, pointsInSpace.Dequeue().Position + offset, Time.deltaTime * speed);
        }
    }
}
