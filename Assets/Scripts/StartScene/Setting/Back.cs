using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public Animator animator;
    public Animator Menu;
    public GameObject Setting;

    private void OnMouseDown()
    {
        animator.SetBool("_setting", false);
        Menu.SetBool("Menu", true);
        StartCoroutine(DeleteObject(1f));
    }

    private IEnumerator DeleteObject(float value)
    {
        yield return new WaitForSeconds(value);
        Setting.SetActive(false);
    }

}
