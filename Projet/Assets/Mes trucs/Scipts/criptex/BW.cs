using UnityEngine;

public class BW : MonoBehaviour
{
    public HingeJoint hinge;
    public HingeJoint hinge2;
    public JointMotor motor;
    public JointMotor motor2;
    public AudioSource roue;
    public AudioSource levier;

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lever"))
        {
            hinge.useMotor = true;

            motor = hinge.motor;
            motor.force = 500f;          // puissance élevée
            motor.targetVelocity = 25f;  // vitesse positive = tourne dans un sens
            motor.freeSpin = false;
            
            motor2 = hinge.motor;
            motor2.force = 500f;          // puissance élevée
            motor2.targetVelocity = 25f;  // vitesse positive = tourne dans un sens
            motor2.freeSpin = false;
            
            roue.Play();
            levier.Play();
            hinge.motor = motor;
            hinge2.motor = motor2;
        }
    }

    void OnTriggerExit(Collider other)
    {
        hinge.useMotor = false;
        hinge2.useMotor = false;
        roue.Stop();

    }
}
