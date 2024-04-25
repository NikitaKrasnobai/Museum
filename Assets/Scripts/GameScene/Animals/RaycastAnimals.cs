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
    public AudioClip Гомель;
    public AudioClip Брест;
    public AudioClip Витебск;
    public AudioClip Могилв;
    public AudioClip Минск;
    public AudioClip Гродно;
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

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ";
                    else CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ";

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

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "пїЅпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ";
                    else CanvasText.text = "пїЅпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ";

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

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ";
                    else CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ";

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

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ";
                    else CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ";

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
                                Player.clip = Могилв;
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

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ";
                    else CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ";

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

                    if (AnimalAnimator.GetBool("IsTalk")) CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=red>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ";
                    else CanvasText.text = "HпїЅпїЅпїЅпїЅпїЅпїЅ <color=green>пїЅ</color> пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ";

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
