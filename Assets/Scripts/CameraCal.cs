using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCal : MonoBehaviour
{
    void Start()
    {
        // Find the main camera in the scene
        Camera mainCamera = Camera.main;

        // Check if the main camera exists
        if (mainCamera != null)
        {
            // Set the camera's position to (4, current y position, current z position)
            mainCamera.transform.position = new Vector3(4f, mainCamera.transform.position.y, mainCamera.transform.position.z);
        }
        else
        {
            Debug.LogWarning("Main camera not found in the scene.");
        }
    }
}
