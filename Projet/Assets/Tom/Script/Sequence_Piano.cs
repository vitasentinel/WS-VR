using UnityEngine;
using System.Collections.Generic;

public class Sequence_Piano : MonoBehaviour
{
    public static Sequence_Piano Instance;
    private List<string> G_Sequence = new List<string> {"Fa", "Ré", "Ré", "La", "Do", "La", "Mi", "Do" };
    private List<string> Sequence = new List<string>();
    public bool Is_G_Sequence = true;

    private void Awake()
    {
        Instance = this;
    }

    public void KeyPressed (string note)
    {
        Sequence.Add(note);

        if (Sequence.Count > G_Sequence.Count)
        {
            Sequence.RemoveAt(0);
        }

        if (Is_G_Sequence)
        {
            Debug.Log("Alleluhia");
        }

    }
    public bool IsGSequence()
    {
        if (Sequence.Count != G_Sequence.Count)
        {
            Is_G_Sequence = false;
        }
        else
        {
            for (int i = 0; i < G_Sequence.Count; i++)
            {
                if (Sequence[i] != G_Sequence[i])
                {
                    Is_G_Sequence = false;
                    break;
                }
                
            }
        }
        return Is_G_Sequence;
    }    
}
