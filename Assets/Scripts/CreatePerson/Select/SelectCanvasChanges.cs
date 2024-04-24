using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCanvasChanges : MonoBehaviour
{
    private void OnDisable()
    {
        GameObject[] panels = GameObject.FindGameObjectsWithTag("Finish");

        foreach (GameObject item in panels)
        {
            Destroy(item);
        }
    }
}
