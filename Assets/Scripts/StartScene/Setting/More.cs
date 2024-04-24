
using UnityEngine;

public class More : MonoBehaviour
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

            foreach (GameObject gameObj in massMoreGameObj)
            {
                gameObj.SetActive(true);
            }

            foreach (GameObject gameObj in massGameObj)
            {
                gameObj.SetActive(false);
            }

        }
        if (_volume.active == true)
        {
            _volumeAnimator.SetBool("Change", false);
            _volume.SetActive(false);

            foreach (GameObject gameObj in massMoreGameObj)
            {
                gameObj.SetActive(true);
            }

            foreach (GameObject gameObj in massVolumeObj)
            {
                gameObj.SetActive(false);
            }

        }
        if (_more.active == false)
        {
            _more.SetActive(true);
            _moreAnimator.SetBool("Change", true);

            foreach (GameObject gameObj in massMoreGameObj)
            {
                gameObj.SetActive(true);
            }

        }
    }


}
