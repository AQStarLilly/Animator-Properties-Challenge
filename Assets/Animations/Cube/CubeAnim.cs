using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnim : MonoBehaviour
{
    public Animator animator;
    bool rotate;
    public GameObject text;

    private void Start()
    {
        text.SetActive(false);
        rotate = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (rotate == false)
            {
                text.SetActive(true);
                rotate = true;
            }
            else if (rotate == true)
            {
                text.SetActive(false);
                rotate = false;
            }           
        }

        if (rotate == false)
        {
            animator.SetBool("rotate", false);
        }
        if (rotate == true)
        {
            animator.SetBool("rotate", true);
        }
    }
}
