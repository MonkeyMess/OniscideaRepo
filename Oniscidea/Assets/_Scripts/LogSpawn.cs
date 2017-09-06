using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawn : MonoBehaviour {

    [SerializeField]
    public GameObject LogCollectable;
	// Use this for initialization
	void Start ()
    {
        CreateCollectable();

    }
    void CreateCollectable()
    {
        var collect = Instantiate(LogCollectable);
        collect.transform.parent = transform;
        collect.transform.Translate(Random.Range(-10, 10), -6, Random.Range(-5, 500));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
