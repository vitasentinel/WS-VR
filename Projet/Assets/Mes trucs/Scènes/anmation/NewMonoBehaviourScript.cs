using Assets.Mes_trucs.Scènes.anmation;
using Oculus.Interaction;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Windows;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject ballerine;
    public float openRot, closeRot, speed;
    public bool opening;
    void Update()
    {
        Vector3 currentRot = ballerine.transform.localEulerAngles;
        if (opening)
        {
            if (currentRot.y > openRot)
            {
                ballerine.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, openRot, currentRot.z), speed * Time.deltaTime);
            }
        }
        else
        {
            if (currentRot.y > closeRot)
            {
                ballerine.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, openRot, currentRot.z), speed * Time.deltaTime);
            }
        }
    }
}
