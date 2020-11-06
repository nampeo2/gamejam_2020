using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public Transform player_transform;
    // Start is called before the first frame update
    void Start()
    {
        player_transform = GameObject.Find("main_character").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //this.transform.Translate(new Vector3(player_transform.position.x, player_transform.position.y, -10f));
        transform.position = new Vector3(player_transform.position.x, player_transform.position.y, -10f);
    }
}
