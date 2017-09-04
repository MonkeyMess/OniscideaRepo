using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    float speed;

    private Rigidbody rd;

    void Awake ()
    {
        rd = GetComponent<Rigidbody>();
    }

	// Use this for initialization
	void Start ()
    {
        //rd = GetComponent<Rigidbody>();
        rd.velocity = Vector3.forward * speed;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float hAxis = Input.GetAxis("Horizontal");
        //float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis,0,0);

        rd.MovePosition(transform.position + movement);
    }
}
