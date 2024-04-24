
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public GameObject CloseScene;
    private void OnMouseDown()
    {
        
        Animator closeAnimation = CloseScene.GetComponent<Animator>();
        closeAnimation.SetBool("OpeningScene", true);
        SceneManager.LoadScene(0);

    }
}
