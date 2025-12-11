using System;
using NUnit.Framework.Constraints;
using UnityEngine;

public class Verifpos : MonoBehaviour
{
    public GameObject ballerine;
    public bool pos1 = false;
    public bool pos2 = false;
    public bool pos3 = false;
    public bool pos4 = false;
    public bool pos5 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pos1"))
        {
            pos1 = true;
        }
        else if (other.CompareTag("pos2"))
        {
            pos2 = true;
        }
        else if (other.CompareTag("pos3"))
        {
            pos3 = true;
        }
        else if (other.CompareTag("pos4"))
        {
            pos4 = true;
        }
        else if (other.CompareTag("pos5"))
        {
            pos5 = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("pos1"))
        {
            pos1 = false;
        }
        else if (other.CompareTag("pos2"))
        {
            pos2 = false;
        }
        else if (other.CompareTag("pos3"))
        {
            pos3 = false;
        }
        else if (other.CompareTag("pos4"))
        {
            pos4 = false;
        }
        else if (other.CompareTag("pos5"))
        {
            pos5 = false;
        }
    }
    // integrer la ballerine qui descend et le morceau qui remonte
    public void Update()
    {
        if (pos1 && pos2 && pos3 && pos4 && pos5)
        {
            ballerine.SetActive(false);
        }
    }
}
