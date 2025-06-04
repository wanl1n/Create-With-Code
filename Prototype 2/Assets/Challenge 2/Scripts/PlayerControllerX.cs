using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 2;
    private float timer = 0;
    private bool spawned = false;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > cooldown && spawned)
        {
            timer = 0;
            spawned = false;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !spawned)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawned = true;
            timer = 0;
        }
    }
}
