using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailsCheckBox : MonoBehaviour
{
    public GameObject checkBox;
    int i;
    private void OnMouseDown()
    {
        if (PlayerPrefs.HasKey("Details"))
        {
            i = PlayerPrefs.GetInt("Details");
            if (i == 1)
            {
                checkBox.SetActive(false);
                PlayerPrefs.SetInt("Details", 0);
            }
            if (i == 0)
            {
                checkBox.SetActive(true);
                PlayerPrefs.SetInt("Details", 1);
            }
        }
        else
        {
            PlayerPrefs.SetInt("Details", 0);
            checkBox.SetActive(false);
        }
    }
}
