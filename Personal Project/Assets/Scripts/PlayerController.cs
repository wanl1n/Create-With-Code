using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;

    private float horizontalInput;
    private float verticalInput;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * speed * Time.deltaTime, 0, verticalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }

    private void Attack()
    {
        // Attack.
    }
}
