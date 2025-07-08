using UnityEngine;
using UnityEngine.InputSystem;

public class motion : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public float rotationSpeed = 1f; // Degrees per frame

    private Rigidbody rb;
    private bool isGrounded;

    private float rotationInput;
    private float verticalInput;

    private PlayerControl controls;

    void Awake()
    {
        controls = new PlayerControl();

        // A/D or Left/Right Arrow for rotation
        controls.Player.Move.performed += ctx => rotationInput = ctx.ReadValue<float>();
        controls.Player.Move.canceled += ctx => rotationInput = 0f;

        // W/S or Up/Down Arrow for forward/backward
        controls.Player.MoveVertical.performed += ctx => verticalInput = ctx.ReadValue<float>();
        controls.Player.MoveVertical.canceled += ctx => verticalInput = 0f;

        // Jump
        controls.Player.Jump.performed += ctx =>
        {
            if (isGrounded)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isGrounded = false;
            }
        };
    }

    void OnEnable() => controls.Enable();
    void OnDisable() => controls.Disable();

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Rotate left/right
        transform.Rotate(Vector3.up, rotationInput * rotationSpeed);

        // Move forward/backward in the object's facing direction
        Vector3 moveDirection = transform.forward * verticalInput * moveSpeed;
        rb.linearVelocity = new Vector3(moveDirection.x, rb.linearVelocity.y, moveDirection.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }
}
