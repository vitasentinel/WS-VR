using UnityEngine;
using System.Collections.Generic;

public class verifTuyaux : MonoBehaviour
{
    public List<RotateTuyaux> RotateTuyaux = new List<RotateTuyaux>();
    public int nb_true;

    void CheckRotateTuyaux()
    {
        foreach (var tuyaux in RotateTuyaux)
        {
            if (tuyaux.transform.rotation == tuyaux.GoalRotation)
            {
                tuyaux.goodRotation = true;
                nb_true++;
            }
        }

        if (nb_true == RotateTuyaux.Count)
        {
            // integrer la recup du morceau de componium
            Debug.Log("you win");
        }
    }


    void Update()
    {
        CheckRotateTuyaux();
    }
    
    
    
}
