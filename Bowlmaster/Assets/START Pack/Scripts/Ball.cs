using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector3 launchVelocity;

    private Rigidbody Rigidbody;
    private AudioSource audioSource;
	// Use this for initialization
	void Start ()
    {
        Rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        Launch();
    }

    public void Launch()
    {
        Rigidbody.velocity = launchVelocity;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update () {
	}
}
