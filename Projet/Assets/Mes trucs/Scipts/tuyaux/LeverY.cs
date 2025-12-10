using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;


public class LeverY : MonoBehaviour
{
    
    public XRGrabInteractable grabInteractable;
    public List<RotateTuyaux> RotateTuyaux = new List<RotateTuyaux>();
    
    void Awake()
    {
        // Abonnement aux événements
        grabInteractable.selectEntered.AddListener(OnGrabbed);
    }
    
    void OnGrabbed(SelectEnterEventArgs args)
    {
        foreach (var tuyaux in RotateTuyaux)
        {
            tuyaux.RotateY();
        }
    }
    
}
