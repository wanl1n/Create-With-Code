using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Transform player;      // Reference to the player
    protected float speed = 3f;      // Movement speed
    protected float stopDistance = 0f; // How close the chicken gets before stopping

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        FollowPlayer();
    }

    protected virtual void FollowPlayer()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > stopDistance)
        {
            // Move towards the player
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;

            // Optional: make the chicken face the player
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }
    }
}
