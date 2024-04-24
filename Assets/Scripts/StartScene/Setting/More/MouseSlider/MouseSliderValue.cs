using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MouseSliderValue : MonoBehaviour
{
    public float mouseSensitivity;

    private void FixedUpdate()
    {
        mouseSensitivity = PlayerPrefs.GetFloat("MouseSensitivity");

        SystemCursor.SetGlobalSensitivity((int)mouseSensitivity);
    }
}
