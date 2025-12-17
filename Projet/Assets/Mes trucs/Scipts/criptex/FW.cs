using UnityEngine;

public class FW : MonoBehaviour
{
    public HingeJoint hinge;
    public JointMotor motor;
    public AudioSource roue;
    public AudioSource levier;

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lever"))
        {
            hinge.useMotor = true;

            motor = hinge.motor;
            motor.force = 500f;          // puissance élevée
            motor.targetVelocity = -25f;  // vitesse positive = tourne dans un sens
            motor.freeSpin = false;

            hinge.motor = motor;
            roue.Play();
            levier.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        hinge.useMotor = false;

    }
}
