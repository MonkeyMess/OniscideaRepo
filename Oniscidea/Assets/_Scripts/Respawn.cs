﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    private Transform woodlouse;
    [SerializeField]
    private Transform respawnPoint;
    [SerializeField]
    float speed;
    
    void OnTriggerEnter(Collider other)
    {
        //if (woodlouse.position = respawnPoint)
        woodlouse.transform.position = respawnPoint.transform.position;
        //woodlouse.transform.rotation.x.ToString();
        woodlouse.position = Vector3.forward * speed;
        //woodlouse.transform.position = Vector3.forward;
    }
	// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
