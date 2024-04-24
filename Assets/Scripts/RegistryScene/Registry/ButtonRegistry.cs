using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRegistry : MonoBehaviour
{
    private void OnMouseDown()
    {
        Application.OpenURL("https://www.cyberforum.ru/unity/thread2738309.html" + Application.identifier);
    }
}
