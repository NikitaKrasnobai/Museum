using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateButton : MonoBehaviour
{
    private GameObject player;

    public GameObject SelectCanvas;

    public GameObject CreateCanvas;

    private void OnMouseDown()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (player != null) Destroy(player);

        SelectCanvas.SetActive(false);

        CreateCanvas.SetActive(true);
    }
}
