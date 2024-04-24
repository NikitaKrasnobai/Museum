using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Running : MonoBehaviour
{
    public float speed = 40f;

    private Animator animator;

    private GameObject character;

    private Rigidbody characterRigidbody;

    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player");

        characterRigidbody = character.GetComponent<Rigidbody>();

        if (characterRigidbody == null ) characterRigidbody = character.AddComponent<Rigidbody>();

        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        Vector3 move;

        float sensivity = PlayerPrefs.GetFloat("MouseSensitivity") * 5;

        float mouseX = Input.GetAxis("Horizontal") * sensivity * Time.deltaTime;

        float mouseY = Input.GetAxis("Vertical") * sensivity * Time.deltaTime;

        if (mouseX != 0 || mouseY != 0)
        {
            if (mouseY > 0.1)
            {
                animator.SetBool("IsRun", true);
            }
            else animator.SetBool("IsRun", false);

            if (mouseY < -0.1) animator.SetBool("BackRunning", true);
            else animator.SetBool("BackRunning", false);

            if (mouseX > 0.1) animator.SetBool("RightRunning", true);
            else animator.SetBool("RightRunning", false);
            
            if (mouseX < -0.1) animator.SetBool("LeftRunning", true);
            else animator.SetBool("LeftRunning", false);
        }

        move = transform.right * mouseX + transform.forward * mouseY;

        characterRigidbody.velocity = move * speed;
    }
}
