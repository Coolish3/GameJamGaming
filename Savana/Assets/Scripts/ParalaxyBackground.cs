using UnityEngine;

public class ParalaxyBackground : MonoBehaviour
{
    [SerializeField] private float parallaxEffectMultiplier;
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    private void Update()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;

        transform.position = new Vector3(
            transform.position.x + deltaMovement.x * parallaxEffectMultiplier,
            transform.position.y,
            transform.position.z
        );

        lastCameraPosition = cameraTransform.position;

    }
}
