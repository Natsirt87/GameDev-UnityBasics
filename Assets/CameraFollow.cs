using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero;

    void Update() 
    {
      Vector3 targetPosition = target.position + offset;
      Vector3 smoothVector = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothSpeed);
      smoothVector.z = -10;
      transform.position = smoothVector;
    }
}
