using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public GameObject setting;
    public GameObject menu;
    public bool _setting = false;
    public Animator Animator;

    private void OnMouseDown()
    {

        if (setting.active == false)
        {
            setting.SetActive(true);
            Animator.SetBool("Menu", false);
        }
    }
}
