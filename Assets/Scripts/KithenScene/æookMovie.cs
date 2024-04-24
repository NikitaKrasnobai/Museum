using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СookMovie : MonoBehaviour
{
    public bool Cut = false;
    public Animator cookAnimator;
    void Start()
    {
        cookAnimator = GetComponent<Animator>();

        cookAnimator.SetBool("IsWalk", Cut);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Cut == true)
            {
                cookAnimator.SetBool("IsWalk", false);
                Cut = false;
            }
            else
            {
                cookAnimator.SetBool("IsWalk", true);
                Cut = true;
            }
           
        }
    }
}
