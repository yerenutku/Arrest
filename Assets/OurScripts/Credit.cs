using UnityEngine;
using System.Collections;

public class Credit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Invoke ("wait", 5.0f);

	}
	void wait(){
		Application.LoadLevel ("credit");
	}
}
