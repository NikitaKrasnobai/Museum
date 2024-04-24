using UnityEngine;

public class ReturnToSelect : MonoBehaviour
{
    private GameObject player;

    public GameObject selectCanvas;

    public GameObject createCanvas;



    private void OnMouseDown()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (player != null) Destroy(player);

        selectCanvas.SetActive(true);

        createCanvas.SetActive(false);

        Persons pensons = new Persons();

        pensons = (Persons)GetComponent("Persons");
    }
}

