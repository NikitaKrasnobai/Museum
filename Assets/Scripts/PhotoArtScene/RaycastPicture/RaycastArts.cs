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
    public AudioClip Исаев;
    public AudioClip Бакст;
    public AudioClip Бархатков;
    public AudioClip Бируля;
    public AudioClip Бущиков;
    public AudioClip Орда;
    public AudioClip Савицкий;
    public AudioClip Сутин;
    public AudioClip Язеп;
    public AudioClip Хруцкий;
    public AudioClip Батальонок;
    public AudioClip Сазонов;
    public AudioClip Шагал;
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
                    CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=orange>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene("GameScene");
                    }
                    break;
                case "пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
<<<<<<< Updated upstream
                            Player.clip = Исаев;
=======
                            Player.clip = audio1;
>>>>>>> Stashed changes
                            Player.Play();
                        }
                    }
                    
                    break;
                case "пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ-пїЅпїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio2;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio3;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio4;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio5;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio6;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ 2":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio1;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ 3":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio3;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ - пїЅ пїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio2;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio1;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio2;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio1;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio5;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio6;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = audio2;
                            Player.Play();
                        }
                    }
                    break;
                case "пїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ - пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ";
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
