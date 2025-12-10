using Meta.WitAi;
using UnityEngine;

public class MoveActive : MonoBehaviour
{
    public Vector3 initialPosition;
    public bool is_activated;
    public void Start()
    {
        initialPosition = transform.position;
    }

    public void MoveObject()
    {
        if (!is_activated)
        {
            transform.position = new Vector3(0, -4.5f, 0);
            is_activated = true;
        }
        else if (is_activated)
        {
            transform.position = initialPosition;
            is_activated = false;
        }
    }


}
