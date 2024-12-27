using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairController : MonoBehaviour
{
    [SerializeField] private RectTransform crosshairRect; // Drag the crosshair RectTransform here
    [SerializeField] private float sensitivity = 5f;      // Rotation sensitivity
    [SerializeField] private float smoothSpeed = 10f;     // Smoothness of rotation

    private Vector3 currentRotation; // Tracks current rotation values

    void Start()
    {
        // Ensure crosshair starts centered
        if (crosshairRect != null)
            crosshairRect.anchoredPosition = Vector2.zero;
    }

    void Update()
    {
        // Get mouse movement
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Update rotation values based on mouse input
        currentRotation.x -= mouseY * sensitivity; // Vertical movement affects X rotation
        currentRotation.y += mouseX * sensitivity; // Horizontal movement affects Y rotation

        // Smooth rotation for a natural feel
        Vector3 smoothedRotation = Vector3.Lerp(transform.localEulerAngles, currentRotation, Time.deltaTime * smoothSpeed);

        // Apply rotation to the crosshair
        transform.localEulerAngles = smoothedRotation;
    }
}


