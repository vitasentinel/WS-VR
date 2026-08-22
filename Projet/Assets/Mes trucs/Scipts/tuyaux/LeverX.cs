using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;


public class LeverX : MonoBehaviour
{
    public List<RotateTuyaux> RotateTuyaux = new List<RotateTuyaux>();
    public XRSimpleInteractable SimpleInteractable;
    public AudioSource source;
    public verifTuyaux verifTuyaux;
    
    
    void Awake()
    {
        // Abonnement aux événements
        SimpleInteractable.selectEntered.AddListener(OnGrabbed);
    }
    
    void OnGrabbed(SelectEnterEventArgs args)
    {
        foreach (var tuyaux in RotateTuyaux)
        {
            tuyaux.RotateX();
            source.Play();
            verifTuyaux.CheckRotateTuyaux();
        }
    }
    
}
