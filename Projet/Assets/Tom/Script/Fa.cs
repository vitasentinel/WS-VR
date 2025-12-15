using UnityEngine;
using DG.Tweening;
using Oculus.Interaction.Feedback;
public class Fa : MonoBehaviour
{
    [SerializeField] private AudioClip audioDO = null;
    public string Note = "Fa";
    public float Activated = -4f;
    private bool IsActivated = false;
    private HingeJoint hinge;

    private AudioSource Touche_Fa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        hinge= GetComponent<HingeJoint>();
    }
    void Update()
    {
        float angle = hinge.angle;

        if (!IsActivated && angle <= Activated)
        {
            IsActivated = true;
            Sequence_Piano.Instance.KeyPressed(Note);
        }
        if (IsActivated && angle > Activated + 1f)
        {
            IsActivated= false;
        }
    }
    public void Awake()
    {
        Touche_Fa = GetComponent<AudioSource>();
    }

   
}
