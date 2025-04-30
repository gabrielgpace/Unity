using UnityEditor.Rendering;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offSet = new Vector3(0, 5, -7);

    void LateUpdate()
    {
        followPlayer(player);
    }

    private void followPlayer(GameObject player)
    {
        transform.position = player.transform.position + offSet;
    }
}
