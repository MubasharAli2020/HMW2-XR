using UnityEngine;

public class ToolInteraction : MonoBehaviour
{
    public Camera mainCamera;
    public Camera toolCamera;

    void Update()
    {
        // Perform raycasting to determine if the player is looking through the tool
        RaycastHit hit;
        if (Physics.Raycast(toolCamera.transform.position, toolCamera.transform.forward, out hit))
        {
            // If the ray hits the hidden object, switch to the tool camera
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("HiddenObject"))
            {
                mainCamera.enabled = false;
                toolCamera.enabled = true;
            }
            else
            {
                mainCamera.enabled = true;
                toolCamera.enabled = false;
            }
        }
    }
}