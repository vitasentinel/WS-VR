using UnityEngine;

public class book4 : MonoBehaviour
{
    public PorteBiblio porteBiblio;
    void OntriggerEnter(Collider other)
    {
        if (other.CompareTag("Book4"))
        {
            porteBiblio.book4 = true;
        }
        porteBiblio.MoveBiblio();
    }
}
