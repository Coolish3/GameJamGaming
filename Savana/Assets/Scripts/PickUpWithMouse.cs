using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpWithMouse : MonoBehaviour
{
    [SerializeField] private float forceAmount = 10f;
    [SerializeField] private Rigidbody2D rb;

    private bool isHolding = false;

    void Update()
    {



        if (Mouse.current.leftButton.isPressed)
        {
            Vector2 mousePos2D = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());


            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null && hit.collider.attachedRigidbody == rb || isHolding == true)
            {
                Debug.Log("Mouse world position: " + mousePos2D);

                Vector2 direction = (mousePos2D - (Vector2)transform.position).normalized;

                rb.AddForce(direction * forceAmount, ForceMode2D.Force);

                isHolding = true;
            }


        }

        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            isHolding = false;
        }
    }


}
