using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSpawner : MonoBehaviour {

    public GameObject[] pathObjects;
    public GameObject End;
    // Use this for initialization
    void Start()
    {
        //var path = Instantiate(pathObjects[0]);
        //path.transform.parent = transform;
        int offset = 0;
        //int Y = 0;
        while (offset < 800)
        {
            CreatePath(offset);
            offset += 21/2;

            if (offset == 799)
            {
                //Y = 1;
                EndPath(offset);
                offset += 10;
            }
            
        }

        //CreateRandomPath(0);
        //CreateRandomPath(10);
        //CreateRandomPath(20);
        //CreateRandomPath(30);
        //CreateRandomPath(40);
        //CreateRandomPath(50);

    }

    void CreatePath(float offset)
    {
        int pathIndex = Random.Range(0, pathObjects.Length);
        var path = Instantiate(pathObjects[pathIndex]);
        path.transform.parent = transform;
        path.transform.Translate(0, 0, offset);
    }
    void EndPath(float offset)
    {
        var end = Instantiate(End);
        end.transform.parent = transform;
        end.transform.Translate(0, 0, offset);

    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
