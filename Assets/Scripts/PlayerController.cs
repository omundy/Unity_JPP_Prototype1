using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 5.0f;

    public InputAction moveAction;
    public Vector2 moveInput;

    void Start()
    {
        moveAction.Enable();
    }

    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        // move forward / backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        // rotate vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
        // // move x / y only
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * moveInput.x);
    }
}
