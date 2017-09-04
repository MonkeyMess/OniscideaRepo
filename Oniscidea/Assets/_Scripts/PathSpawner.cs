using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSpawner : MonoBehaviour {

    public GameObject[] pathObjects;
    // Use this for initialization
    void Start()
    {
        //var path = Instantiate(pathObjects[0]);
        //path.transform.parent = transform;
        int offset = 0;
        while (offset < 500)
        {
            CreateRandomPath(offset);
            offset += 21/2;
        }

        //CreateRandomPath(0);
        //CreateRandomPath(10);
        //CreateRandomPath(20);
        //CreateRandomPath(30);
        //CreateRandomPath(40);
        //CreateRandomPath(50);

    }

    void CreateRandomPath(float offset)
    {
        int pathIndex = Random.Range(0, pathObjects.Length);
        var path = Instantiate(pathObjects[pathIndex]);
        path.transform.parent = transform;
        path.transform.Translate(0, 0, offset);
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
