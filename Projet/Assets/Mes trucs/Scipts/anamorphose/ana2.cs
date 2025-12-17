using System;
using System.Collections.Generic;
using UnityEngine;

public class ana2 : MonoBehaviour
{
    public List<GameObject> anas = new List<GameObject>();
    public GameObject trigger;

    private void OnTriggerExit(Collider other)
    {
        if (anas.Contains(other.gameObject))
        {
            anas.Remove(other.gameObject);
        }
        if (anas.Count == 0)
        {
            trigger.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!anas.Contains(other.gameObject))
        {
            anas.Add(other.gameObject);
        }

        if (anas.Count >= 1)
        {
            trigger.SetActive(false);
        }
    }
}
