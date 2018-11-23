using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

    public GameObject player;

	void Start () {
		if (player == null) {
            Debug.Log("Player is undefined");
        }
	}
	
	void Update () {
        Vector3 playerPosition = player.transform.position;
        Vector3 cam = gameObject.transform.position;
        Vector3 distanceToTravel = playerPosition - cam;
        distanceToTravel *= .25f;
        gameObject.transform.position += new Vector3(distanceToTravel.x, distanceToTravel.y, 0);
        gameObject.transform.rotation = new Quaternion();
    }
}
