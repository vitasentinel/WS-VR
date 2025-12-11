using System.Xml.Linq;
using UnityEngine;

public class ballerinerentre : MonoBehaviour
{
    public GameObject ballerine;
    public float openRot,closeRot,speed;
    public bool opening;


    Void Update()
    {
        Vector3 currentRot = ballerine.transform.localEulerAngles;
        if (opening)
        {
            if (currentRot.y > openRot)
            {
                ballerine.transformlocalEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, openRot, currentRot.z), speed * Time.deltaTime);
            }
        }
        else (closing)
        {
            if (currentRot.y > closeRot)
            {
                ballerine.transformlocalEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, openRot, currentRot.z), speed * Time.deltaTime);
            }
        }

;
    }
}
