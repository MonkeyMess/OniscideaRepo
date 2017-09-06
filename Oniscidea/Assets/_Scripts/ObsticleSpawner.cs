using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawner : MonoBehaviour {

    [SerializeField]
    public GameObject TrunkObj;
    [SerializeField]
    public GameObject SapBlobObj;

    //public GameObject 
	// Use this for initialization
	void Start ()
    {
        CreateTrunk();
        CreateTrunk();
        CreateSapBlob();
        CreateSapBlob();
	}

    //private void OnBeforeTransformParentChanged()
    void CreateTrunk()
    {
        var tree = Instantiate(TrunkObj);
        tree.transform.parent = transform;
        tree.transform.Translate(Random.Range(-10,10),-6,Random.Range(-5,500));
    }
    void CreateSapBlob()
    {
        var blob = Instantiate(SapBlobObj);
        blob.transform.parent = transform;
        blob.transform.Translate(Random.Range(-10, 10), -6, Random.Range(-5, 500));
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
