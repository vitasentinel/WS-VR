using UnityEngine;
using UnityEngine.SceneManagement;

public class debutJeu : MonoBehaviour
{
    public string sceneName;
    public void CommencerJeu()
    {
        SceneManager.LoadScene(sceneName);
    }
}
