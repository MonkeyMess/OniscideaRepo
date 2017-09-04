using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour {

    [SerializeField]
    Transform woodlouse;

    Vector3 offset;
    [SerializeField]
    float smoothRate;
	// Use this for initialization
	void Start ()
    {
        offset = woodlouse.position - transform.position;
        //smoothRate = 5;	
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void FixedUpdate ()
    {
        Vector3 currentPos = transform.position;
        Vector3 newPos = woodlouse.position - offset;

        transform.position = Vector3.Lerp(currentPos, newPos, smoothRate);
    }
}
