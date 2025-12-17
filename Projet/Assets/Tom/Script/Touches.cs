using System;
using UnityEngine;
using DG.Tweening;
using Oculus.Interaction.Feedback;
public class Touches : MonoBehaviour
{

    public AudioSource source;
    public Sequence_Piano piano;
    
    public string Note;

    private AudioSource Touche_Do;
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("main"))
        {
            piano.noteJoue.Add(Note);
            source.Play();
        }
    }
    
}
