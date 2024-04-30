using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIndex = 0;

    void Start()
    {
        // Disable all cameras except the first one
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }
    }

    void Update()
    {
        // Check for input to toggle between cameras
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Disable the current camera
            cameras[currentCameraIndex].gameObject.SetActive(false);

            // Move to the next camera
            currentCameraIndex++;

            // If we've reached the end of the camera array, loop back to the first camera
            if (currentCameraIndex == cameras.Length)
            {
                currentCameraIndex = 0;
            }

            // Enable the new current camera
            cameras[currentCameraIndex].gameObject.SetActive(true);
        }
    }
}
