using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RRotation : MonoBehaviour
{
    public float rotationSpeed = 1.0f; // 1 rotation per second
    public float rotationAngle = 15.0f; // 15 degrees per rotation

    void Update()
    {
        // Calculate the rotation amount based on the desired angle and speed
        float rotationAmount = rotationAngle * rotationSpeed * Time.deltaTime;

        // Rotate the object around its X-axis
        transform.Rotate(Vector3.right * rotationAmount);
    }
}
