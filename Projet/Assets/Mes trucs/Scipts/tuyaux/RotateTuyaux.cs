using System;
using Unity.Mathematics;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class RotateTuyaux : MonoBehaviour
{
    public Quaternion targetRotationX = quaternion.Euler(90f, 0f, 0f);
    public Quaternion targetRotationY = quaternion.Euler(0f, 90f, 0f);
    public Quaternion targetRotationZ = quaternion.Euler(0f, 0f, 90f);
    public Quaternion initialRotation = quaternion.identity;
    public Quaternion GoalRotation = quaternion.Euler(0f, 0f, 0f);
    public bool goodRotation = false;
    public AudioSource source;
    
    

    public void RotateX()
    {
        transform.rotation *= Quaternion.Euler(targetRotationX.eulerAngles);
        source.Play();
    }

    public void RotateY()
    {
        transform.rotation *= Quaternion.Euler(targetRotationY.eulerAngles);
        source.Play();
    }

    public void RotateZ()
    {
        transform.rotation *= Quaternion.Euler(targetRotationZ.eulerAngles);
        source.Play();
    }

    public void ResetPosition()
    {
        transform.rotation = initialRotation;
        source.Play();
    }
    
    
    
    
}
