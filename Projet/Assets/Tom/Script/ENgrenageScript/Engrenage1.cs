using UnityEngine;

public class Engrenage1 : MonoBehaviour
{
    [SerializeField] private BoxCollider box;
    [SerializeField] private Transform Snap;
    public float SnapDistance = 10f;
    private bool IsSnapped = false;
    private Rigidbody Rigidbody;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        if (IsSnapped)
        {
            box.enabled = false;
        }

        float distance = Vector3.Distance(transform.position, Snap.position);

        if ( (distance <= SnapDistance))
        {
            SnapEngrenage();
        }
    }

    void SnapEngrenage()
    {
        IsSnapped = true;

        Rigidbody.isKinematic = true;

        transform.position = Snap.position;
        transform.rotation = Snap.rotation;
    }
}
