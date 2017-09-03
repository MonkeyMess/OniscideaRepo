using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 15;

    private Rigidbody rid;

	// Use this for initialization
	void Start ()
    {
        rid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis,0,vAxis) * speed * Time.deltaTime;

        rid.MovePosition(transform.position + movement);
    }
}
