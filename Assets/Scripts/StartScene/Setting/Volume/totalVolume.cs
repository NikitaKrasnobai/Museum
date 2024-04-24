using UnityEngine;

public class totalVolume: MonoBehaviour
{
    public GameObject checkBox;
    public GameObject slider;
    float i;
    private void OnMouseDown()
    {
        if (PlayerPrefs.HasKey("totalVolume"))
        {
            i = PlayerPrefs.GetFloat("totalVolume");  
            if (i == 1 || i > 0)
            {
                checkBox.SetActive(false);
                PlayerPrefs.SetFloat("totalVolume", 0);
                AudioListener.volume = 0;
                slider.SetActive(false);
            }
            if (i == 0)
            {
                checkBox.SetActive(true);
                PlayerPrefs.SetFloat("totalVolume", 1);
                AudioListener.volume = 1;
                slider.SetActive(true);
            }
        }
        else
        {
            PlayerPrefs.SetFloat("totalVolume", 0);
            checkBox.SetActive(false);
        }
    }



}
