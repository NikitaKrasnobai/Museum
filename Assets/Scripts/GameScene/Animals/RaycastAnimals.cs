using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaycastAnimals : MonoBehaviour
{
    public TMP_Text CanvasText;
    public Animator AnimalAnimator;

    public AudioSource Player;

<<<<<<< Updated upstream
    public AudioClip ������;
    public AudioClip �����;
    public AudioClip �������;
    public AudioClip ������;
    public AudioClip �����;
    public AudioClip ������;
=======
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;
    public AudioClip audio5;
    public AudioClip audio6;
>>>>>>> Stashed changes

    private void Awake()
    {
        Player.Stop();
    }

    void Update()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 40);

        if (hit.collider == null) CanvasText.text = String.Empty;
        else
        {
            switch (hit.collider.gameObject.tag)
            {
                case "Rabbit":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "H������ <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "H������ <color=green>�</color> ��� ������������� �������� � ����������� �������";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Player.isPlaying)
                        {
                            if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                        }
                        else
                        {
                            if (Input.GetKeyDown(KeyCode.E))
                            {
                                Player.clip = audio1;
                                Player.Play();
                            }
                        }
                    }
                    
                    break;
                case "Deer":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "������� <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "������� <color=green>�</color> ��� ������������� �������� � ��������� �������";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Player.isPlaying)
                        {
                            if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                        }
                        else
                        {
                            if (Input.GetKeyDown(KeyCode.E))
                            {
                                    Player.clip = audio2;
                                    Player.Play();
                            }
                        }
                    }

                    break;
                case "Moose":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "H������ <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "H������ <color=green>�</color> ��� ������������� �������� � ���������� �������";

                    if (Input.GetKeyDown(KeyCode.E)) 
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Player.isPlaying)
                        {
                            if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                        }
                        else
                        {
                            if (Input.GetKeyDown(KeyCode.E))
                            {
                                Player.clip = audio3;
                                Player.Play();
                            }
                        }
                    }

                    break;
                case "Bear":

                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "H������ <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "H������ <color=green>�</color> ��� ������������� �������� � ���������� �������";

                    if (Input.GetKeyDown(KeyCode.E)) 
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Player.isPlaying)
                        {
                            if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                        }
                        else
                        {
                            if (Input.GetKeyDown(KeyCode.E))
                            {
<<<<<<< Updated upstream
                                Player.clip = ������;
=======
                                Player.clip = audio4;
>>>>>>> Stashed changes
                                Player.Play();
                            }
                        }
                    }

                    break;

                case "Fox":
                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "H������ <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "H������ <color=green>�</color> ��� ������������� �������� � ������� �������";

                    if (Input.GetKeyDown(KeyCode.E)) 
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Input.GetKeyDown(KeyCode.E))
                        {
                           
                            if (Player.isPlaying)
                            {
                                if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                            }
                            else
                            {
                                if (Input.GetKeyDown(KeyCode.E))
                                {
                                    Player.clip = audio5;
                                    Player.Play();
                                }
                            }
                        }
                    }

                    break;

                case "Bunny":
                    AnimalAnimator = hit.collider.transform.GetComponent<Animator>();

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "H������ <color=red>�</color> ��� ����������� ������������� ��������";
                    else CanvasText.text = "H������ <color=green>�</color> ��� ������������� �������� � ������� �������";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (AnimalAnimator.GetBool("IsTalk")) AnimalAnimator.SetBool("IsTalk", false);
                        else AnimalAnimator.SetBool("IsTalk", true);

                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            if (Player.isPlaying)
                            {
                                if (Input.GetKeyDown(KeyCode.E)) { Player.Stop(); }
                            }
                            else
                            {
                                if (Input.GetKeyDown(KeyCode.E))
                                {
                                    Player.clip = audio6;
                                    Player.Play();
                                }
                            }
                        }
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
