using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator animator;
    bool isOpen; // Track chest state

    private void Start()
    {
        isOpen = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Press Tab to toggle animation
        {
            if (!isOpen) // If chest is closed, open it
            {
                animator.SetTrigger("Open Door"); // Use Trigger Parameter
                Debug.Log("Trigger Sent: Open Door");
                isOpen = true;
            }
            else // If chest is open, close it 
            {
                animator.SetTrigger("Close Door");
                Debug.Log("Trigger Sent: Close Door");
                isOpen = false;
            }
        }
    }
}
