using UnityEngine;
using System.Collections.Generic;

public class verifTuyaux : MonoBehaviour
{
    public List<RotateTuyaux> RotateTuyaux = new List<RotateTuyaux>();
    public int nb_true;
    public int count;
    public AudioSource source;
    public GameObject cage;
    public Vector3 targetPos;

    void Start()
    {
        targetPos = cage.transform.position;
        targetPos.y += 2f;
    }
    
    public void CheckRotateTuyaux()
    {
        foreach (var tuyaux in RotateTuyaux)
        {
            if (tuyaux.transform.rotation == tuyaux.GoalRotation)
            {
                tuyaux.goodRotation = true;
                nb_true++;
            }
        }

        if (nb_true == RotateTuyaux.Count && count == 0)
        {
            source.Play();
            cage.transform.position = Vector3.Slerp(cage.transform.position, targetPos, 0.5f);
            count = 1;
        }
    }
    
    
    
}
