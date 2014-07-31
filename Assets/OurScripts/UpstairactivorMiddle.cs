using UnityEngine;
using System.Collections;

public class UpstairactivorMiddle : MonoBehaviour {
	public GameObject upstair;
	public GameObject stair;
	BoxCollider upstir;
	BoxCollider stir;
	int i=0;

	// Use this for initialization
	void Start () {
		upstir = upstair.GetComponent<BoxCollider> ();
		stir = stair.GetComponent<BoxCollider> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter()
	{

		if(i%2==0){
			upstir.isTrigger = false;
			stir.isTrigger = true;
			i++;}
		else
		{
			upstir.isTrigger = true;
			stir.isTrigger = false;
			i++;
		}
		 
			/*upstir.isTrigger = true;
			stir.isTrigger = false;*/

		
	}
}
