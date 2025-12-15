using UnityEngine;
public class ZoneTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " est entré dans la zone !");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " est sorti de la zone !");
    }
}
