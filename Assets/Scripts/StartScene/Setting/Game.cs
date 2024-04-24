using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
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
        if (_more.active == true)
        {
            _moreAnimator.SetBool("Change", false);
            _more.SetActive(false);

            foreach(GameObject gameObj in massGameObj) 
            {
                gameObj.SetActive(true);
            }

            foreach (GameObject gameObj in massMoreGameObj)
            {
                gameObj.SetActive(false);
            }
        }
        if (_volume.active == true)
        {
            _volumeAnimator.SetBool("Change", false);
            _volume.SetActive(false);

            foreach (GameObject gameObj in massGameObj)
            {
                gameObj.SetActive(true);
            }

            foreach (GameObject gameObj in massVolumeObj)
            {
                gameObj.SetActive(false);
            }
        }
        if (_game.active == false)
        {
            _game.SetActive(true);
            _gameAnimator.SetBool("Change", true);

            foreach (GameObject gameObj in massGameObj)
            {
                gameObj.SetActive(true);
            }
        }

    }

    


}
