using UnityEngine;

public class Neutral : MonoBehaviour
{
    public HingeJoint hinge;
    public JointMotor motor;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lever"))
        {
            hinge.useMotor = true;

            motor = hinge.motor;
            motor.force = 500f;          // puissance élevée
            motor.targetVelocity = 0f;  // vitesse positive = tourne dans un sens
            motor.freeSpin = false;

            hinge.motor = motor;
        }
    }
}
