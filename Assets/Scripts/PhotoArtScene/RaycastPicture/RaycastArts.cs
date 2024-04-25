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
                    CanvasText.text = "Hажмите <color=orange>Е</color> для того чтобы выйти на главную сцену";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene("GameScene");
                    }
                    break;
                case "Александр Исачев - Автопортрет":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Исаев;
                            Player.Play();
                        }
                    }
                    
                    break;
                case "Витольд Бялыницкий-Бируля - Зимний сон":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Бируля;
                            Player.Play();
                        }
                    }
                    break;
                case "Егор Батальонок - романтический пейзаж":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Батальонок;
                            Player.Play();
                        }
                    }
                    break;
                case "Иван Хруцкий - Портрет неизвестной с цветами и фруктами":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Хруцкий;
                            Player.Play();
                        }
                    }
                    break;
                case "Игорь Бархатков - борьба за реализм":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Бархатков;
                            Player.Play();
                        }
                    }
                    break;
                case "Лев Бакст - Русские сезоны":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Бакст;
                            Player.Play();
                        }
                    }
                    break;
                case "Лев Бакст - Русские сезоны 2":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Бакст;
                            Player.Play();
                        }
                    }
                    break;
                case "Лев Бакст - Русские сезоны 3":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Бакст;
                            Player.Play();
                        }
                    }
                    break;
                case "Николай Бущик - у нас не любят состояние радости":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Бущиков;
                            Player.Play();
                        }
                    }
                    break;
                case "Наполеон Орда - Несвижский замок Радзивиллов":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Орда;
                            Player.Play();
                        }
                    }
                    break;
                case "Василий Сазонов - Куликовское поле":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Сазонов;
                            Player.Play();
                        }
                    }
                    break;
                case "Язэп Дроздович - Космос":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Язеп;
                            Player.Play();
                        }
                    }
                    break;
                case "Хаим Сутин - Ева":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Сутин;
                            Player.Play();
                        }
                    }
                    break;
                case "Марк Шагал - Прогулка над городом":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Шагал;
                            Player.Play();
                        }
                    }
                    break;
                case "Марк Шагал - Прогулка":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Шагал;
                            Player.Play();
                        }
                    }
                    break;
                case "Марк Шагал - Двойной портрет":
                    if (Player.isPlaying)
                    {
                        CanvasText.text = "Hажмите <color=red>Е</color> чтобы остановить гида";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.Stop();
                        }
                    }
                    else
                    {
                        CanvasText.text = "Hажмите <color=green>Е</color> для прослушивания информации об авторе";
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Player.clip = Шагал;
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
