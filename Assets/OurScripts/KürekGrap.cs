using UnityEngine;
using System.Collections;

public class KürekGrap : MonoBehaviour {
	MeshRenderer mr;
	public bool kürekcarry=false;



	// Use this for initialization
	void Start () {
		transform.gameObject.SetActive (false);
		mr = GetComponent<MeshRenderer> ();




	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnTriggerStay()
	{
		//if içeri girildiyse görünür ol. değilse görünmez kal.
		//görünür ise space yakala.

		if (Input.GetKeyDown ("space")) 
		{
			kürekcarry=true;
			mr.enabled=false;



			
		}
		
	}
}
