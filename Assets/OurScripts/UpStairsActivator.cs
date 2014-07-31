using UnityEngine;
using System.Collections;

public class UpStairsActivator : MonoBehaviour {
	public GameObject upstair;
	public GameObject stair;
	BoxCollider upstir;
	BoxCollider stir;
	public GameObject key;
	KeyUp ku;
	// Use this for initialization
	void Start () {
		upstir = upstair.GetComponent<BoxCollider> ();
		stir = stair.GetComponent<BoxCollider> ();
		ku = key.GetComponent<KeyUp> ();
	}
	
	// Update is called once per frame
	void Update () {


	
	}
	void OnTriggerEnter()
	{
		if (!ku.keygetted) {
						upstir.isTrigger = false;
						stir.isTrigger = true;
				} else {
			upstir.isTrigger = true;
			stir.isTrigger = false;
				}

	}
}
