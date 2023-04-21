using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPerson : MonoBehaviour
{
    public float rotSpeed = 146.9f;
    public Vector3 midPoint = Vector3.zero;

    void Update()
    {
      
        transform.RotateAround(midPoint, Vector3.up, rotSpeed * Time.deltaTime);

    }
}
