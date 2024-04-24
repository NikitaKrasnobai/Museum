
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void OnMouseEnter()
    {
        animator.SetBool("isMouseOver", true);
        audioSource.Play();
    }


    private void OnMouseExit()
    {
        animator.SetBool("isMouseOver", false);
    }
}
