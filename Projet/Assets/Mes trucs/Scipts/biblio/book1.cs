using UnityEngine;

public class book1 : MonoBehaviour
{
    public PorteBiblio porteBiblio;
    void OntriggerEnter(Collider other)
    {
        if (other.CompareTag("Book1"))
        {
            porteBiblio.book1 = true;
        }
        porteBiblio.MoveBiblio();
    }
}
