using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmGunPositionFix : MonoBehaviour
{
    public Transform meshes;
    public Transform arms;
    public Transform gun;

    public Vector3 armsOffset = new Vector3(0, -0.1f, 0);
    public Vector3 gunOffset = new Vector3(36.502f, -4f, -48.547f);

    public Vector3 gunLocalRotation = new Vector3(0, -280.072f, 0);

    void Start()
    {
        if (meshes == null || arms == null || gun == null)
        {
            Debug.LogError("Meshes, arms, or gun not assigned!");
            enabled = false; // Disable script if not properly set up
            return;
        }

        Debug.Log($"Start Positions - Meshes: {meshes.position}, Arms: {arms.localPosition}, Gun: {gun.localPosition}");
    }

    void LateUpdate()
    {
        if (meshes == null || arms == null || gun == null) return;

        // Apply offsets
        arms.localPosition = armsOffset;
        gun.localPosition = gunOffset;

        // Apply rotation to gun
        gun.localRotation = Quaternion.Euler(gunLocalRotation);

        // Debug log
        Debug.Log($"LateUpdate - Arms: {arms.localPosition}, Gun: {gun.localPosition}");
    }
}
