using System;
using JetBrains.Annotations;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private LayerMask Mask;
    Ray Ray;
    RaycastHit Hit;
    public Ana_condition ana_Condition;
    public bool ana1;
    public bool ana2;
    public bool cible1;
    public bool cible2;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mask = LayerMask.GetMask("Detectable");
    }

    void Update()
    {
        if (ana1 && cible1)
        {
            Debug.Log("win");
        }

        if (ana2 && cible2)
        {
            Debug.Log("win2");
        }
    }
    
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ana1"))
        {
            ana1 = true;
            Debug.Log("bon endroit");
        }
        else if (other.gameObject.CompareTag("cible ana1"))
        {
            cible1 = true;
            Debug.Log("cible trouvé");
        }

        if (other.gameObject.CompareTag("ana2"))
        {
            ana2 = true;
        }
        else if (other.gameObject.CompareTag("cible ana2"))
        {
            cible2 = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("ana1"))
        {
            ana1 = false;
        }
        else if (other.gameObject.CompareTag("cible ana1"))
        {
            cible1 = false;
        }

        if (other.gameObject.CompareTag("ana2"))
        {
            ana2 = false;
        }
        else if (other.gameObject.CompareTag("cible ana2"))
        {
            cible2 = false;
        }
    }
}
