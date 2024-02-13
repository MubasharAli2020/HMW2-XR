using UnityEngine;

public class VRControllerInput : MonoBehaviour
{
    // Reference to the object you want to show/hide
    public GameObject objectToShowHide;

    // Update is called once per frame
    void Update()
    {
        // Example: Check if the trigger button is pressed on the VR controller
        if (Input.GetButtonDown("Fire2")) // Adjust "Fire1" to the appropriate input for your VR controller
        {
            // Toggle the visibility of the object
            objectToShowHide.SetActive(!objectToShowHide.activeSelf);
        }
    }
}
