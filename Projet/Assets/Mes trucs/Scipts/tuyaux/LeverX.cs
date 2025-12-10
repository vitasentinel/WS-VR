using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;


public class LeverX : MonoBehaviour
{
    public List<RotateTuyaux> RotateTuyaux = new List<RotateTuyaux>();
    public XRGrabInteractable grabInteractable;
    
    
    void Awake()
    {
        // Abonnement aux événements
        grabInteractable.selectEntered.AddListener(OnGrabbed);
    }
    
    void OnGrabbed(SelectEnterEventArgs args)
    {
        foreach (var tuyaux in RotateTuyaux)
        {
            tuyaux.RotateX();
        }
    }
    
}
