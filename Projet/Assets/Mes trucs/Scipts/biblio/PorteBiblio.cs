using System;
using UnityEngine;

public class PorteBiblio : MonoBehaviour
{
    public bool book1;
    public bool book2;
    public bool book3;
    public bool book4;
    
    public Vector3 targetPos = new Vector3(-4.5f, 0.1f, 3.25f);

    public void MoveBiblio()
    {
        if (book1 && book2 && book3 && book4)
        {
            transform.position = Vector3.Slerp(transform.position, targetPos, Time.deltaTime * 1.5f);
        }
    }
}

    

