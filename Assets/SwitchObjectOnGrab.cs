using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SwitchObjectOnGrab : MonoBehaviour
{
    public GameObject objectToShow1;
    public GameObject objectToShow2;
    public GameObject objectToShow3;
    public GameObject objectToShow4;
    public GameObject objectToShow5;
    public Transform targetPosition1; 
    public Transform targetPosition2; 

    public float threshold = 0.1f; 

    private bool hasBeenGrabbed = false;
    private XRGrabInteractable grabInteractable;

    void Update()
    {
        
        float distance1 = Vector3.Distance(transform.position, targetPosition1.position);
        float distance2 = Vector3.Distance(transform.position, targetPosition2.position);
        float a = distance2 - distance1;
        Debug.Log(distance1);
        Debug.Log(distance2);
        if (distance2-distance1 < threshold)
        {
            grabInteractable = GetComponent<XRGrabInteractable>();
            grabInteractable.onSelectEntered.AddListener(OnGrabbed);    
            grabInteractable.onSelectExited.AddListener(OnReleased);

        }
    }
    private void OnDestroy()
    {
        grabInteractable.onSelectEntered.RemoveListener(OnGrabbed);
        grabInteractable.onSelectExited.RemoveListener(OnReleased);
    }

    private void OnGrabbed(XRBaseInteractor interactor)
    {
        if (!hasBeenGrabbed)
        {
            hasBeenGrabbed = true;
            objectToShow1.SetActive(true);
            objectToShow2.SetActive(true);
            objectToShow3.SetActive(true);
            objectToShow4.SetActive(true);
            objectToShow5.SetActive(true);
        }
    }

    private void OnReleased(XRBaseInteractor interactor)
    {
        hasBeenGrabbed = false;
        objectToShow1.SetActive(false);
        objectToShow2.SetActive(false);
        objectToShow3.SetActive(false);
        objectToShow4.SetActive(false);
        objectToShow5.SetActive(false);

    }
}




