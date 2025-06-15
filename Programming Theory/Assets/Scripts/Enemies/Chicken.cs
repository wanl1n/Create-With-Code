using System.Collections;
using UnityEngine;

// INHERITANCE
public class Chicken : Enemy
{
    private bool isFollowing = true;

    protected void Start()
    {
        base.Start();

        speed = 1f;
        StartCoroutine(StopAtIntervals());
    }

    // POLYMORPHISM
    protected override void Update() 
    {
        if (isFollowing)
        {
            FollowPlayer();
        }
    }

    IEnumerator StopAtIntervals()
    {
        isFollowing = false;
        yield return new WaitForSeconds(Random.Range(1, 3));
        isFollowing = true;
        yield return new WaitForSeconds(Random.Range(3, 5));
        StartCoroutine(StopAtIntervals());
    }
}
