using UnityEngine;
using System.Collections;

public class Flowerkutucuk : MonoBehaviour {
	public GameObject cafekapi;
	DoorOpener DO;
	GameObject kutucuk;
	// Use this for initialization
	void Start () {
		DO = cafekapi.GetComponent<DoorOpener> ();
		kutucuk = transform.GetChild (0).transform.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (DO.Interior) {
						kutucuk.SetActive (true);

				
		
				} else {
				
			kutucuk.SetActive(false);
		}
	
	}
}
