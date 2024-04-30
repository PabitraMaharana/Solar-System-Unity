using UnityEngine;

public class rotation : MonoBehaviour
{
    public string planetTag = "Planet";
    private GameObject planet;
    public float speed = 20f;
    private Vector3 axisOfRotation;

    void Start()
    {
        // Find the planet object with the specified tag
        planet = GameObject.FindGameObjectWithTag(planetTag);
        
        if (planet != null)
        {
            // Calculate the axis of rotation (perpendicular to the vector from planet to this object)
            axisOfRotation = Vector3.Cross(transform.position - planet.transform.position, Vector3.right).normalized;
        }
        else
        {
            Debug.LogError("No object with tag '" + planetTag + "' found.");
        }
    }

    void Update()
    {
        if (planet != null)
        {
            // Rotate around the planet
            transform.RotateAround(planet.transform.position, axisOfRotation, Time.deltaTime * speed); // Adjust the speed as needed
        }
    }
}
