using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ResetTuyaux : MonoBehaviour
{
    public List<RotateTuyaux> RotateTuyaux = new List<RotateTuyaux>();
    
    public XRSimpleInteractable SimpleInteractable;
    
    void Awake()
    {
        // Abonnement aux événements
        SimpleInteractable.selectEntered.AddListener(OnSelectEntered);
    }
    
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        foreach (var tuyaux in RotateTuyaux)
        {
            tuyaux.ResetPosition();
        }
    }
}
