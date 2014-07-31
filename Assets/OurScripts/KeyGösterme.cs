using UnityEngine;
using System.Collections;

public class KeyGösterme : MonoBehaviour {
	DoorOpener DO;
	public GameObject housedoor;
	public GameObject key;
	// Use this for initialization
	void Start () {
		DO = housedoor.GetComponent<DoorOpener> ();
		key.transform.gameObject.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update () {
		if (DO.Interior) {
						key.transform.gameObject.SetActive (true);		
			
				} else {
			key.transform.gameObject.SetActive(false);
				}
	}
}
