using UnityEngine;

public class book2 : MonoBehaviour
{
    public PorteBiblio porteBiblio;
    void OntriggerEnter(Collider other)
    {
        if (other.CompareTag("Book2"))
        {
            porteBiblio.book2 = true;
        }
        porteBiblio.MoveBiblio();
    }
}
