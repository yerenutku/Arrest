using UnityEngine;
using System.Collections;

public class Stairs_Start : MonoBehaviour {

	DoorOpener DO;
	public GameObject DOpener;
	bool upmarkeron=false;
	public GameObject Stairs;
	BoxCollider Stair;
	public Material mt;
	public GameObject key;
	KeyUp ku;
	public GameObject upmark;
	// Use this for initialization
	void Start () {
		DO = DOpener.GetComponent<DoorOpener> ();
		Stair = Stairs.GetComponent<BoxCollider> ();
		ku = key.GetComponent<KeyUp> ();

	}

	
	// Update is called once per frame
	void Update () {
		if (upmarkeron) {

			if(Input.GetKeyUp("up"))
			   {

				Stair.isTrigger=false;

				//Debug.Log("yukarıyurume");

			}
		
		}
	}
	void OnTriggerEnter()
	{   


		if (DO.Interior) {
					
			upmarkeron = true;
						
			upmark.SetActive(true);
			if(ku.keygetted)
			{
				Stair.isTrigger=true;
			}

				}
		}
	void OnTriggerExit()
	{

		if (DO.Interior) {
			upmarkeron = false;
			
			upmark.SetActive(false);
		}


	}
}
