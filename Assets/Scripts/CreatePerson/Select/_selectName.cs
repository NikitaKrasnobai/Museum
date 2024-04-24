using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class _selectName : MonoBehaviour
{
    public string[] massFolderFiles;

    private string mypath;

    public List<string> items;

    public string[] _item;

    private TMP_Text _text;

    public GameObject backgroundImageOBJ;

    private Image backgroundImage;

    private void OnMouseDown()
    {
        GameObject _player = GameObject.FindGameObjectWithTag("Player");
        if (_player != null) Destroy(_player);

        GameObject findColorImage = GameObject.FindGameObjectWithTag("backgroundImageOBJ");
        if (findColorImage != null)
        {
            Image colorImage = findColorImage.GetComponent<Image>();
            if (colorImage != null)
            {
                colorImage.color = new Color(1, 1, 1, 1f);
                findColorImage.tag = "Untagged";
            }
        }

        items.Clear();

        GameObject nameCharacterObject = GameObject.FindGameObjectWithTag("GameController");
        if (nameCharacterObject != null)
        {
            TMP_Text nameCharacterText = nameCharacterObject.GetComponent<TMP_Text>();
            if (nameCharacterText != null) nameCharacterText.color = Color.white;
            nameCharacterObject.tag = "Untagged";
        }

        _text = GetComponent<TMP_Text>();
        _text.tag = "GameController";
        _text.color = Color.green;

        backgroundImage = backgroundImageOBJ.GetComponent<Image>();
        if (backgroundImage.color != Color.cyan)
        {
            backgroundImage.color = Color.cyan;
            backgroundImageOBJ.tag = "backgroundImageOBJ";

        }

        mypath = Application.dataPath + "/Resources/Person";
        massFolderFiles = Directory.GetFiles(mypath).ToArray<string>();
        foreach (string item in massFolderFiles)
        {
            if (item.Length > 10) _item = item.Split('\\');
            if (_item[1] != null)
            {
                try
                {
                    if (_item[1].Split('.').Length == 2 && _item[1].Split('.')[1] == "prefab") items.Add(_item[1].Split('.')[0].ToString());
                }
                catch { }
            }
        }
        foreach (string item in items)
        {
            if (item == _text.text.ToString())
            {
                Debug.Log(_text.text.ToString());
                GameObject player = Instantiate(Resources.Load("Person/" + _text.text)) as GameObject;
                player.transform.localPosition = new Vector3(1, 3.5f, -22.4f);
                player.transform.localRotation = new Quaternion(0, 90, 0, -90);
                player.transform.localScale = new Vector3(1f, 1f, 1f);
                player.tag = "Player";
                player.name = _text.text.ToString();

               

                PlayerPrefs.SetString("PlayerName", _text.text.ToString());

                _text.tag = "GameController";

            }
        }
    }
}
