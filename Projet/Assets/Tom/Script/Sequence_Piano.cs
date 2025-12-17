using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Sequence_Piano : MonoBehaviour
{
    public string sequence = "FaRéRéLaDoLaMiDo";
    public List<string> noteJoue = new List<string>();
    public GameObject triggerFin;

    private void Update()
    {
        if (noteJoue.Count >= 8)
        {
            string seq = string.Join("", noteJoue);
            if (seq == sequence)
            {
                triggerFin.SetActive(true);
            }
            else
            {
                noteJoue.Clear();
            }
        }
    }
}
