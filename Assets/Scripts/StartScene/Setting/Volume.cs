using UnityEngine;

public class Volume : MonoBehaviour
{
    public GameObject _game;

    public GameObject _volume;

    public GameObject _more;

    public Animator _moreAnimator;

    public Animator _gameAnimator;

    public Animator _volumeAnimator;

    public GameObject[] massGameObj;

    public GameObject[] massVolumeObj;

    public GameObject[] massMoreGameObj;

    private void OnMouseDown()
    {
        if (_game.active == true)
        {
            _gameAnimator.SetBool("Change", false);
            _game.SetActive(false);

            foreach (GameObject gameObj in massVolumeObj)
            {
                gameObj.SetActive(true);
            }

            foreach (GameObject gameObj in massGameObj)
            {
                gameObj.SetActive(false);
            }

        }
        if (_more.active == true)
        {
            _moreAnimator.SetBool("Change", false);
            _more.SetActive(false);

            foreach (GameObject gameObj in massVolumeObj)
            {
                gameObj.SetActive(true);
            }

            foreach (GameObject gameObj in massMoreGameObj)
            {
                gameObj.SetActive(false);
            }

        }
        if (_volume.active == false)
        {
            _volume.SetActive(true);
            _volumeAnimator.SetBool("Change", true);

            foreach (GameObject gameObj in massVolumeObj)
            {
                gameObj.SetActive(true);
            }
        }
    }
   
}
