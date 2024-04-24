using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class RaycastPicture : MonoBehaviour
{
    public TMP_Text CanvasText;
    void Update()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,40);

        if (hit.collider == null) CanvasText.text = String.Empty;
        else
        {
            switch (hit.collider.gameObject.tag)
            {
                case "Belarus":
                    CanvasText.text = "Hажмите <color=orange>Е</color> для путешествия в мир Аграрно-экономического колледжа Республики Беларусь";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Application.OpenURL("http://ggaek.by/" + Application.identifier);
                    }
                    break;
                case "Cinema":
                    CanvasText.text = "Hажмите <color=green>Е</color> для путешествия в мир киносьёмки Беларуси";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(3);
                    }
                    break;
                case "Kitchen":
                    CanvasText.text = "Hажмите <color=green>Е</color> для путешествия на кухню Республики Беларусь";
                    break;
                case "ArtGalery":
                    CanvasText.text = "Hажмите <color=green>Е</color> для знакомства с миром живописи Республики Беларусь";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene(4);
                    }
                    break;
                case "Finish":
                    CanvasText.text = "Вы просмотрели все доступные локации, для выхода к главному меню необходимо нажать <color=green>Е</color>";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene("StartScene");
                        Cursor.lockState = CursorLockMode.Confined;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
