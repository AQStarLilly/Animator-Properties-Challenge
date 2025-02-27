using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPulseController : MonoBehaviour
{
    public Animator animator;
    public Light lightSource;

    [Range(0f, 2f)]
    public float speedValue = 0f;

    public float minSpeed = 0f;
    public float maxSpeed = 2f;
    public float scrollSensitivity = 0.1f;

    void Update()
    {
        float scroll = Input.mouseScrollDelta.y;

        if (scroll != 0)
        {
            // Adjust speed based on scroll direction
            speedValue += scroll * scrollSensitivity;

            // Clamp the value to prevent it from going out of range
            speedValue = Mathf.Clamp(speedValue, minSpeed, maxSpeed);

            // Set the Animator parameter
            animator.SetFloat("Speed", speedValue);
        }
    }
}
