using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Ball ball;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        //Calculate and store the offset value by getting the distance between
        //the player's position and camera's position
        offset = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void Update () {
        //Set the position of the camera's transform to be the same as
        //player's, but offset by the calculated offset distance.
        transform.position = ball.transform.position + offset;
    }
}
