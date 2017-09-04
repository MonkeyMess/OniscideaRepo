using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawner : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}

    //private void OnBeforeTransformParentChanged()
    void CreateTree()
    {
        var tree = Instantiate(TreeTrunk);
        tree.transform.parent = transform;
        tree.transform.Translate(Random.Range(-10,))
    }

    // Update is called once per frame
    void Update ()
        {
		
	}
}
