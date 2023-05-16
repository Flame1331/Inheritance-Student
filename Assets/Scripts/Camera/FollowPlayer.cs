using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject Player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
        transform.position = offset;
    }
}
