using UnityEngine;

public class ballerine_test_avectrigger : MonoBehaviour
{
    public GameObject ballerine; // La porte à contrôler
    public float openAngle = 90f; // Angle d'ouverture
    public float speed = 2f; // Vitesse de rotation

    private bool open = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        closedRotation = ballerine.transform.rotation;
        openRotation = Quaternion.Euler(ballerine.transform.eulerAngles + new Vector3(0, openAngle, 0));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            open = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            open = false;
        }
    }

    void Update()
    {
        if (open)
        {
            ballerine.transform.rotation = Quaternion.Slerp(ballerine.transform.rotation, openRotation, Time.deltaTime * speed);
        }
        else
        {
            ballerine.transform.rotation = Quaternion.Slerp(ballerine.transform.rotation, closedRotation, Time.deltaTime * speed);
        }
    }
}

