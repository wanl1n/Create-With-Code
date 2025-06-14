using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    //private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 offset = new Vector3(0, 2.5f, 6);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
