using System.Collections;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    private float rotateSpeed = 2.0f;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
