using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float launchSpeed;

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
        Rigidbody.velocity = new Vector3(0, 0, launchSpeed);
        audioSource.Play();
    }

    // Update is called once per frame
    void Update () {
	}
}
