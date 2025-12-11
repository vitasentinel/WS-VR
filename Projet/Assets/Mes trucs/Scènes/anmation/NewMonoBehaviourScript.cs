using Oculus.Interaction;
using UnityEngine;
using UnityEngine.Windows;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public class NewEmptyCSharpScript
    {
        public int speed = 7;
    }

    void Update()
    {
        float horizontal Input.GetAxis("horizontal");
        float vertical Input.GetAxis("vertical");
        Vector3 movement = new Vector3(horizontal*speed *Time.deltaTime 0, vertical*speed*Time*deltaTime);
        transform.position = transform.position + movement;
    }
}
