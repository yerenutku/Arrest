using UnityEngine;
using System.Collections;

public class StartStairmiddle : MonoBehaviour {
	public GameObject upstair;
	public GameObject stair;
	BoxCollider upstir;
	BoxCollider stir;
	int i=0;
	public GameObject door;
	DoorOpener DO;
	// Use this for initialization
	void Start () {
		upstir = upstair.GetComponent<BoxCollider> ();
		stir = stair.GetComponent<BoxCollider> ();
		DO = door.GetComponent<DoorOpener> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter()
	{
		if (DO.Interior) {
						if (i % 2 == 1) {
								upstir.isTrigger = false;
								stir.isTrigger = true;
								i++;
						} else {
								upstir.isTrigger = true;
								stir.isTrigger = false;
								i++;
						}
				}
		/*upstir.isTrigger = true;
			stir.isTrigger = false;*/
		
		
	}
}
