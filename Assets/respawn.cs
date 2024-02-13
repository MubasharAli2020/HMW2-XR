using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public float lowerPositionThreshold = 0f; // Set the threshold position here
    public Vector3 newPosition = new Vector3(0.0388f, 0.52f, -2.7623f); // Set the new position here

    void Update()
    {
        // Check if the current Y position is below the threshold
        if (transform.position.y < lowerPositionThreshold)
        {
            // If yes, move the object to the new position
            transform.position = newPosition;
        }
    }
}
