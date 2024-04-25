using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaycastArts : MonoBehaviour
{
    public TMP_Text CanvasText;

    public AudioSource Player;

<<<<<<< Updated upstream
    public AudioClip �����;
    public AudioClip �����;
    public AudioClip ���������;
    public AudioClip ������;
    public AudioClip �������;
    public AudioClip ����;
    public AudioClip ��������;
    public AudioClip �����;
    public AudioClip ����;
    public AudioClip �������;
    public AudioClip ����������;
    public AudioClip �������;
    public AudioClip �����;
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
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 4);

        if (hit.collider == null) CanvasText.text = String.Empty;
        else
        {
            switch (hit.collider.gameObject.name)
            {
                case "door":
                    CanvasText.text = "H������ <color=orange>�</color> ��� ���� ����� ����� �� ������� �����";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene("GameScene");
                    }
                    break;
                case "��������� ������ - �����������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
<<<<<<< Updated upstream
                            Player.clip = �����;
=======
                            Player.clip = audio1;
>>>>>>> Stashed changes
                            Player.Play();
                        }
                    }
                    
                    break;
                case "������� ����������-������ - ������ ���":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio2;
                            Player.Play();
                        }
                    }
                    break;
                case "���� ���������� - ������������� ������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio3;
                            Player.Play();
                        }
                    }
                    break;
                case "���� ������� - ������� ����������� � ������� � ��������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio4;
                            Player.Play();
                        }
                    }
                    break;
                case "����� ��������� - ������ �� �������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio5;
                            Player.Play();
                        }
                    }
                    break;
                case "��� ����� - ������� ������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio6;
                            Player.Play();
                        }
                    }
                    break;
                case "��� ����� - ������� ������ 2":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio1;
                            Player.Play();
                        }
                    }
                    break;
                case "��� ����� - ������� ������ 3":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio3;
                            Player.Play();
                        }
                    }
                    break;
                case "������� ����� - � ��� �� ����� ��������� �������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio2;
                            Player.Play();
                        }
                    }
                    break;
                case "�������� ���� - ���������� ����� �����������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio1;
                            Player.Play();
                        }
                    }
                    break;
                case "������� ������� - ����������� ����":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio2;
                            Player.Play();
                        }
                    }
                    break;
                case "���� ��������� - ������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio1;
                            Player.Play();
                        }
                    }
                    break;
                case "���� ����� - ���":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio5;
                            Player.Play();
                        }
                    }
                    break;
                case "���� ����� - �������� ��� �������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio6;
                            Player.Play();
                        }
                    }
                    break;
                case "���� ����� - ��������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio2;
                            Player.Play();
                        }
                    }
                    break;
                case "���� ����� - ������� �������":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "H������ <color=red>�</color> ����� ���������� ����";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "H������ <color=green>�</color> ��� ������������� ���������� �� ������";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio1;
                            Player.Play();
                        }
                    }
                    break;
                

                default:
                    break;
            }
        }
    }
}
