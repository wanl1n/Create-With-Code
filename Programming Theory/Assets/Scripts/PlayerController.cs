using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;

    private float horizontalInput;
    private float verticalInput;

    private Rigidbody rb;

    // ENCAPSULATION
    private Camera mainCamera;
    public Camera MainCamera { get; set; }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (mainCamera == null) mainCamera = Camera.main;
    }

    void Update()
    {
        // ABSTRACTION
        Move();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }

        LookAtCursor();
    }

    private void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * speed * Time.deltaTime, 0, verticalInput * speed * Time.deltaTime);
    }

    private void LookAtCursor()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 targetPosition = hit.point;
            Vector3 direction = targetPosition - transform.position;
            direction.y = 0f; // Flatten the direction on the Y-axis

            if (direction.sqrMagnitude > 0.01f) // Avoid rotating on tiny movements
            {
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 720 * Time.deltaTime);
            }
        }
    }

    private void Attack()
    {
        // Attack.
    }

}
