using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreatePersonButton : MonoBehaviour
{
    private GameObject person;

    public GameObject inputFieldName;

    string CharacterName;

    public GameObject beforeCanvas;

    public GameObject afterCanvas;

    private void OnMouseDown()
    {

        person = GameObject.FindGameObjectWithTag("Player");

        if (person != null)
        {
            CharacterName = person.name;
        }
        else { Debug.Log("person");  }


        TMP_InputField nameCharacter = inputFieldName.GetComponent<TMP_InputField>();

        if (nameCharacter.text != string.Empty)
        {
            nameCharacter.image.color = Color.white;
            if (CharacterName != null)
            {
                File.Copy(Application.dataPath + $"/Resources/Models/{CharacterName}.prefab", Application.dataPath + $"/Resources/Person/{nameCharacter.text}.prefab", true);
                File.Copy(Application.dataPath + $"/Resources/Models/{CharacterName}.prefab.meta", Application.dataPath + $"/Resources/Person/{nameCharacter.text}.prefab.meta", true);
                
            }
            else { Debug.Log("CharacterName"); }
        }
        
        else { nameCharacter.image.color = Color.red; }


        /*AssetDatabase.Refresh();*/
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
