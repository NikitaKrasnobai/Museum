using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject AnimationCloseObject;

    private void OnMouseDown()
    {
        AnimationCloseObject.SetActive(true);
        Animator AnimationCloseAnimator = AnimationCloseObject.GetComponent<Animator>();
        AnimationCloseAnimator.SetBool("OpeningScene", true);        
    }


    public void OnAnimationEnded()
    {
        SceneManager.LoadScene(2);
        if (!PlayerPrefs.HasKey("PlayerName"))
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            PlayerPrefs.SetString("PlayerName", player.name);
        }
    }
}
