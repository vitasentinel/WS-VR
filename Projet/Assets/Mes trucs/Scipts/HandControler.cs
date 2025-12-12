using UnityEngine;
using UnityEngine.InputSystem;

public class HandControler : MonoBehaviour
{
    public InputActionProperty triggerValue;
    public InputActionProperty gripValue;
    
    public Animator controller;
    
    void Update()
    {
        float triggger = triggerValue.action.ReadValue<float>();
        float grip = gripValue.action.ReadValue<float>();
        
        controller.SetFloat("Trigger", triggger);
        controller.SetFloat("Grip", grip);
    }
}
