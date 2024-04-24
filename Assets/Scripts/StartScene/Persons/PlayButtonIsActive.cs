using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonIsActive : MonoBehaviour
{
    private GameObject Player;

    public GameObject PlayButton;
    private void FixedUpdate()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (Player != null) PlayButton.SetActive(true);
        if (Player == null) PlayButton.SetActive(false);
    }
}
