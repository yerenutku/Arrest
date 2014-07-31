using UnityEngine;
using System.Collections;

public class DoorOpener : MonoBehaviour {
	public bool Interior=false;
	public GameObject limitter;
	AudioSource kapi;
	public GameObject spotcan;
	//public float ışıkmiktarı;
	//public GameObject directionlig;
	public GameObject direkabi;

	// Use this for initialization
	void Start () {
		direkabi = GameObject.Find ("Directional light");

		kapi = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay()
	{
		if (Interior) {
			spotcan.light.intensity=4f;
			direkabi.light.intensity=0f;
		}
		if (!Interior) {
			spotcan.light.intensity=0f;
			direkabi.light.intensity=0.5f;
		}
		if(Input.GetKeyDown("space"))
		   {
			kapi.Play();
		if (Interior) {
				GameObject shope=transform.parent.GetChild(1).gameObject;
				shope.SetActive(true);
				GameObject shopi=transform.parent.GetChild(2).gameObject;
				shopi.SetActive(false);
				BoxCollider B1=limitter.transform.GetChild(0).gameObject.GetComponent<BoxCollider>();
				B1.isTrigger=true;
				BoxCollider B2=limitter.transform.GetChild(1).gameObject.GetComponent<BoxCollider>();
				B2.isTrigger=true;
				Interior=!Interior;

		}
		else {
				GameObject shope=transform.parent.GetChild(1).gameObject;
				shope.SetActive(false);
				GameObject shopi=transform.parent.GetChild(2).gameObject;
				shopi.SetActive(true);

				BoxCollider B1=limitter.transform.GetChild(0).gameObject.GetComponent<BoxCollider>();
				B1.isTrigger=false;
				BoxCollider B2=limitter.transform.GetChild(1).gameObject.GetComponent<BoxCollider>();
				B2.isTrigger=false;
				Interior=!Interior;

				}
		}


	}
}
