using UnityEngine;

public class Mouse : MonoBehaviour
{
    private GameObject player;
    //private Rigidbody rb;

    private float speed = 35.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 20 || transform.position.x < -20 ||
            transform.position.y > 20 || transform.position.y < -5 ||
            transform.position.z > 11 || transform.position.z < -11)
            Destroy(gameObject);

        Vector3 playerDir = (player.transform.position - transform.position).normalized;
        playerDir = new Vector3(playerDir.x, 0, playerDir.z);
        //rb.AddForce(playerDir * speed * Time.deltaTime);
        transform.Translate(playerDir * speed * Time.deltaTime);
        //transform.position = Mathf.Lerp(transform.position, playerDir, speed * Time.deltaTime);
    }
}
