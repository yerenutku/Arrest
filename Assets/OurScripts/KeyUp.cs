using UnityEngine;
using System.Collections;

public class KeyUp : MonoBehaviour {
	bool Onkey=false;
	public bool keygetted=false;
	MeshRenderer mr;

	// Use this for initialization
	void Start () {
		mr = GetComponent<MeshRenderer> ();


	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Onkey) {
				
		if(Input.GetKeyUp("space"))
			{
				mr.enabled=false;
				keygetted=true;
				///key aldıgını karektere söylicez

			}
		
		}
	}
	void OnTriggerEnter()
	{	
		Debug.Log ("ontrigger enterda");
		Onkey = true;


	}
	void OnTriggerExit()
	{
		Onkey = false;

	}
}
