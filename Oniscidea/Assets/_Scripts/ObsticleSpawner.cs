using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawner : MonoBehaviour {

    [SerializeField]
    public GameObject TrunkObj;
    [SerializeField]
    public GameObject SapBlobObj;
	// Use this for initialization
	void Start ()
    {
        CreateTrunk();
        CreateTrunk();
        CreateTrunk();
        CreateSapBlob();
        CreateSapBlob();
        CreateSapBlob();
	}

    //private void OnBeforeTransformParentChanged()
    void CreateTrunk()
    {
        var tree = Instantiate(TrunkObj);
        tree.transform.parent = transform;
        tree.transform.Translate(Random.Range(-30,30),0,Random.Range(-5,5));
    }
    void CreateSapBlob()
    {
        var blob = Instantiate(SapBlobObj);
        blob.transform.parent = transform;
        blob.transform.Translate(Random.Range(-20, 20), 0, Random.Range(-5, 5));
    }

    // Update is called once per frame
    void Update ()
        {
		
	}
}
