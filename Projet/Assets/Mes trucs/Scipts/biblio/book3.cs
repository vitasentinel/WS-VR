using UnityEngine;

public class book3 : MonoBehaviour
{
    public PorteBiblio porteBiblio;
    void OntriggerEnter(Collider other)
    {
        if (other.CompareTag("Book3"))
        {
            porteBiblio.book3 = true;
        }
        porteBiblio.MoveBiblio();
    }
}
