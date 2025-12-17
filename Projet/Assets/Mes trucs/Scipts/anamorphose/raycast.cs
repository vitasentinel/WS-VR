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
    public GameObject boite;
    public GameObject ballerine;
    public AudioSource source;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mask = LayerMask.GetMask("Detectable");
    }

    public void AnaActivation()
    {
        if (ana1 && cible1)
        {
            if (!boite.activeInHierarchy)
            {
                boite.SetActive(true);
                source.Play();
            }
            
        }

        if (ana2 && cible2)
        {
            if (ballerine.activeInHierarchy)
            {
                ballerine.SetActive(true);
                source.Play();
            }
            
        }
    }
    
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ana1"))
        {
            ana1 = true;
            AnaActivation();
            
        }
        else if (other.gameObject.CompareTag("cible ana1"))
        {
            cible1 = true;
            AnaActivation();
            
        }

        if (other.gameObject.CompareTag("ana2"))
        {
            ana2 = true;
            AnaActivation();
            
        }
        else if (other.gameObject.CompareTag("cible ana2"))
        {
            cible2 = true;
            AnaActivation();
            
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
