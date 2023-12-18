using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class EarthZoomController : MonoBehaviour
{
    public XRController leftController;
    public XRController rightController;
    public Transform earthTransform;
    public float zoomSpeed = 0.1f;
    public float minScale = 0.5f;
    public float maxScale = 2.0f;
    private XRGrabInteractable interactable;

    private float initialDistance;
    private Vector3 initialScale;

    private void Start()
    {
        initialScale = earthTransform.localScale;


        // // Get the XRGrabInteractable component on the Earth GameObject
        // interactable = earthTransform.GetComponent<XRGrabInteractable>();

        // // Set the interactable's interaction layer mask to allow grabbing
        // interactable.interactionLayers = LayerMask.GetMask("Grabbing");
    }

    private void Update()
    {
        if (leftController == null || rightController == null)
        {
            return;
        }

        Vector3 leftPosition = leftController.transform.position;
        Vector3 rightPosition = rightController.transform.position;

        float currentDistance = Vector3.Distance(leftPosition, rightPosition);

        // Check for grip button press on both controllers to initiate grabbing.
        if (Mouse.current != null && Mouse.current.leftButton.isPressed && Mouse.current.rightButton.isPressed)
        {
            if (initialDistance == 0f)
            {
                initialDistance = currentDistance;
            }
            else
            {
                float scaleFactor = currentDistance / initialDistance;
                float newScale = Mathf.Clamp(earthTransform.localScale.x * scaleFactor, minScale, maxScale);
                earthTransform.localScale = new Vector3(newScale, newScale, newScale);
            }
        }
        else
        {
            initialDistance = 0f;
        }
    }
}
