using UnityEngine;
using UnityEngine.UIElements;

public class Ana_condition : MonoBehaviour
{
    public bool G_Rotate = false;
    public Raycast raycastScript;
    // Update is called once per frame
   
    public void Update()
    {
        
    }
    private void OnTriggerStay(Collider collision)
        {
            if (collision.CompareTag("Player"))
            {
                G_Rotate = true;
            }
        }
    
}
