using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private GameObject player;

    private float rotateMouseUp = 0f;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        float sensivity = PlayerPrefs.GetFloat("MouseSensitivity") * 15;
        if (player != null)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;

            rotateMouseUp -= mouseY;
            rotateMouseUp = Mathf.Clamp(rotateMouseUp, -90f, 90f);

            transform.localRotation = Quaternion.Euler(rotateMouseUp, 0f, 0f);

            player.transform.Rotate(Vector3.up * mouseX);
        }
    }
}
