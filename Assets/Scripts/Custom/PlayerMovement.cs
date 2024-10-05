using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;             // Movement speed
    public float maxSpeed = 1f;               // Maximum joystick input to consider running
    public float rotationSpeed = 10f;         // Speed of rotation
    public float gravity = -9.81f;            // Gravity force
    public CharacterController controller;     // Reference to CharacterController

    private Vector3 moveDirection;             // Movement direction
    public Animator animator;                   // Animator reference
    private float currentSpeed;                 // To store the current speed based on joystick input
    private Vector3 verticalVelocity;           // To store vertical velocity

    void Start()
    {
        // Get the Animator component attached to the player
       // animator = GetComponent<Animator>();
    }

    void Update()
    {
        MovePlayer();
        HandleAnimations(); // Handle animations based on movement
        if (Input.GetKeyDown(KeyCode.T))
        {
            PerformAttack();
        }
    }

    void MovePlayer()
    {
        // Get input axes (from Simple Input for mobile, or Input Manager for desktop)
        float horizontal = SimpleInput.GetAxis("Horizontal"); // Use Input.GetAxis("Horizontal") for desktop
        float vertical = SimpleInput.GetAxis("Vertical");     // Use Input.GetAxis("Vertical") for desktop

        // Calculate movement direction
        moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            // Calculate speed based on joystick input magnitude
            currentSpeed = Mathf.Clamp01(moveDirection.magnitude) * moveSpeed;

            // Move the player
            controller.Move(moveDirection * currentSpeed * Time.deltaTime);
        }

        // Handle gravity
        if (controller.isGrounded)
        {
            verticalVelocity.y = 0; // Reset vertical velocity when grounded
        }
        else
        {
            verticalVelocity.y += gravity * Time.deltaTime; // Apply gravity when not grounded
        }

        // Move the player vertically
        controller.Move(verticalVelocity * Time.deltaTime);

        // Rotate the player to face the movement direction (without joystick rotation)
        if (moveDirection.magnitude >= 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

    void HandleAnimations()
    {
        // Update the "Speed" parameter in the Animator to smoothly transition between Idle/Walk/Run
        float animationSpeed = Mathf.Clamp01(moveDirection.magnitude); // Scale between 0 and 1
        animator.SetFloat("Speed", animationSpeed); // Update Animator with the speed
    }

    public void PerformAttack()
    {
        // Trigger the attack animation (this will now affect only the upper body)
        animator.SetTrigger("Attack");

        // Optionally, add hit detection logic here if necessary
    }
}
