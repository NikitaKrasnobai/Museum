using UnityEngine;

public class audioHelper : MonoBehaviour
{
    public GameObject checkBox;
    int i;
    private void OnMouseDown()
    {
        if (PlayerPrefs.HasKey("audioHelper"))
        {
            i = PlayerPrefs.GetInt("audioHelper");
            if (i == 1)
            {
                checkBox.SetActive(false);
                PlayerPrefs.SetInt("audioHelper", 0);
            }
            if (i == 0)
            {
                checkBox.SetActive(true);
                PlayerPrefs.SetInt("audioHelper", 1);
            }
        }
        else
        {
            PlayerPrefs.SetInt("audioHelper", 0);
            checkBox.SetActive(false);
        }
    }
}
