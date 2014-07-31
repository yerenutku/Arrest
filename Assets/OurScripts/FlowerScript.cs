using UnityEngine;
using System.Collections;

public class FlowerScript : MonoBehaviour {
	public Material mt;
	public Texture sevgilisivar;
	public Texture sevgilisiyok;
	public bool cocukvar=false;
	public DoorOpener DOcafe;




	// Use this for initialization
	void Start () {
		mt.mainTexture= sevgilisiyok;

	}
	
	// Update is called once per frame
	void Update () {
		if (DOcafe.Interior&& cocukvar) {
				
			Invoke("wait",5.0f);

		
		}

	
	}
	void OnTriggerStay()
		{
		if (Input.GetKey ("space")) {
						
				Debug.Log ("cicegi aldi");
				

			cocukvar=true;
				mt.mainTexture=sevgilisivar;
				


		}
}
	void wait(){
		Application.LoadLevel ("StartScene");
	}
}
