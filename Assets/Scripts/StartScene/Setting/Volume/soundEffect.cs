using UnityEngine;

public class soundEffect : MonoBehaviour
{
    public GameObject checkBox;
    int i;
    private void OnMouseDown()
    {
        if (PlayerPrefs.HasKey("soundEffect"))
        {
            i = PlayerPrefs.GetInt("soundEffect");
            if (i == 1)
            {
                checkBox.SetActive(false);
                PlayerPrefs.SetInt("soundEffect", 0);
            }
            if (i == 0)
            {
                checkBox.SetActive(true);
                PlayerPrefs.SetInt("soundEffect", 1);
            }
        }
        else
        {
            PlayerPrefs.SetInt("soundEffect", 0);
            checkBox.SetActive(false);
        }
    }
}
