using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    private void Update()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3());

        transform.position=Vector3.SmoothDamp(transform.position, targetPosition,ref velocity, smoothTime);
    }
}
