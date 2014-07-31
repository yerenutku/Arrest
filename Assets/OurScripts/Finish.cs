using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("wait", 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void wait(){

		Application.Quit ();
	}
}
