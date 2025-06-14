using UnityEngine;

public class BoxController : MonoBehaviour
{
    private float speed = 30.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        transform.Translate(xInput * speed * Time.deltaTime, 0, -zInput * speed * Time.deltaTime);
    }
}
