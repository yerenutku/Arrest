using UnityEngine;
using System.Collections;

public class Firstscrren : MonoBehaviour {
	public GameObject spotlight;
	// Use this for initialization
	void Start () {spotlight.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseOver()
	{

		spotlight.SetActive (true);
	}
	void OnMouseExit()
	{
		spotlight.SetActive (false);
	}
	void OnMouseUpAsButton()
	{

		Application.LoadLevel ("StartScene");

	}
}
