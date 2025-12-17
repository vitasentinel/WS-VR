using System.Collections.Generic;
using Unity.VRTemplate;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;


public class LeverZ : MonoBehaviour
{
    
    public XRGrabInteractable grabInteractable;
    public List<RotateTuyaux> RotateTuyaux = new List<RotateTuyaux>();
    public AudioSource source;
    public verifTuyaux verifTuyaux;

    
    void Awake()
    {
        // Abonnement aux événements
        grabInteractable.selectEntered.AddListener(OnGrabbed);
    }
    
    void OnGrabbed(SelectEnterEventArgs args)
    {
        foreach (var tuyaux in RotateTuyaux)
        {
            tuyaux.RotateZ();
            source.Play();
            verifTuyaux.CheckRotateTuyaux();

        }
    }
    
}
