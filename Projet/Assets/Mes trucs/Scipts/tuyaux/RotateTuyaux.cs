using System;
using Unity.Mathematics;
using UnityEngine;

public class RotateTuyaux : MonoBehaviour
{
    public Quaternion targetRotationX = quaternion.Euler(90f, 0f, 0f);
    public Quaternion targetRotationY = quaternion.Euler(0f, 90f, 0f);
    public Quaternion targetRotationZ = quaternion.Euler(0f, 0f, 90f);
    public Quaternion initialRotation = quaternion.identity;
    public Quaternion GoalRotation = quaternion.Euler(0f, 0f, 0f);
    public bool goodRotation = false;
    
    

    public void RotateX()
    {
        transform.rotation *= Quaternion.Euler(targetRotationX.eulerAngles);
    }

    public void RotateY()
    {
        transform.rotation *= Quaternion.Euler(targetRotationY.eulerAngles);
    }

    public void RotateZ()
    {
        transform.rotation *= Quaternion.Euler(targetRotationZ.eulerAngles);
    }

    public void ResetPosition()
    {
        transform.rotation = initialRotation;
    }
    
    
    
    
}
