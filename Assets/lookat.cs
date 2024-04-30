using UnityEngine;

public class lookat : MonoBehaviour
{
    public Camera mainCamera;
    Transform target; // The object to look at

    void Start()
    {
    }

    void Update()
    {
        // Check if the player has clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse position into the scene
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // If the ray hits something
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the object hit is moving
                if (hit.collider.GetComponent<Rigidbody>() != null)
                {
                    // Set the target to the hit object
                    target = hit.transform;
                }
            }
        }

        // If there is a target, make the camera look at it
        if (target != null)
        {
            transform.LookAt(target.position);
        }
    }
}
