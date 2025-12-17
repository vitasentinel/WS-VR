using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    public bool ana1;
    public bool ana2;
    public bool cible1;
    public bool cible2;
    public GameObject boite;
    public GameObject ballerine;
    public GameObject componium;
    public AudioSource source;
    public Material Mana1;
    public Material Mana2;
    public List<GameObject> anas1;
    public List<GameObject> anas2;

    public void AnaActivation()
    {
        if (ana1 && cible1)
        {
            if (!boite.activeInHierarchy)
            {
                foreach (GameObject anas in anas1)
                {
                    Renderer anasRenderer = anas.GetComponent<Renderer>();
                    anasRenderer.material = Mana1;
                }
                boite.SetActive(true);
                source.Play();
            }
            
        }

        if (ana2 && cible2)
        {
            if (!ballerine.activeInHierarchy)
            {
                foreach (GameObject anas in anas2)
                {
                    Renderer anasRenderer = anas.GetComponent<Renderer>();
                    anasRenderer.material = Mana2;
                }
                ballerine.SetActive(true);
                source.Play();
            }
            
        }

        if (ballerine.activeInHierarchy && boite.activeInHierarchy)
        {
            componium.SetActive(true);
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
