using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair3D : MonoBehaviour
{
    public Camera mainCamera; // The camera to raycast from
    public Transform crosshair3D; // The 3D crosshair object in the scene
    public RectTransform crosshairUI; // The 2D UI crosshair element
    public LayerMask raycastLayerMask; // Layers the raycast interacts with
    public float maxDistance = 100f; // Maximum raycast distance
    void Start()
    {
        Cursor.visible = false; // Hide the cursor
        Cursor.lockState = CursorLockMode.Confined; // Keep the cursor within the window
    }
    void Update()
    {
        if (mainCamera == null || crosshair3D == null || crosshairUI == null)
        {
            Debug.LogWarning("Assign all necessary components in the inspector!");
            return;
        }

        // Update UI crosshair to match the mouse position
        Vector3 mousePosition = Input.mousePosition;
        crosshairUI.position = mousePosition;

        // Raycast from the camera to the world based on the mouse position
        Ray ray = mainCamera.ScreenPointToRay(mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, maxDistance, raycastLayerMask))
        {
            // Place the 3D crosshair at the hit point
            crosshair3D.position = hitInfo.point;

            // Optionally align the 3D crosshair to the surface normal
            crosshair3D.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
        else
        {
            // If nothing is hit, place the 3D crosshair at the maximum raycast distance
            crosshair3D.position = ray.origin + ray.direction * maxDistance;
            crosshair3D.rotation = Quaternion.identity; // Reset rotation
        }
    }
}

