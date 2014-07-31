using UnityEngine;
using System.Collections;

public class ChapterSelect : MonoBehaviour {
	public GameObject spot;
	public bool on=false;
	public AudioSource ses;
	public GameObject gui;
	GUIText gt;
	string yazi="";
	// Use this for initialization
	void Start () {
		gt = gui.GetComponent<GUIText> ();
	

	
	}
	
	// Update is called once per frame
	void Update () {
	if (on) {
						spot.SetActive (true);
		//	spot.transform.localPosition = transform.localPosition;
				} else
						spot.SetActive (false);

	}
	void OnMouseEnter()
	{
		Debug.Log ("aaaaaaaaaaaaa");
		on = true;
		ses.Play ();
		if (name == "1") {
			yazi="I remember that day.\n When you getting older, things remembered more clearly.\n I remember the day that ı first met with death.\n My dog... My dog was dead.\nMy mother gave him when ı eight years old.\n He’s name was Blue. I can’t believe his death, his eyes were open.\n Big, beautiful, blue eyes... \nLying down on the ground without any sign of life.\n My mother told me it was natural, but ı couldn’t stand...";
			gt.text = yazi;
			gt.transform.localPosition=new Vector3(0.177f,0.46f,20.01f);
		} else if (name == "2") {
			yazi="Youth... Everything makes you happy, everything makes you laugh.\n Even small events felt beautiful.\n Oh! My first girlfriend. How beautiful, isn’t she?\n She was beautiful, but... \nShe always said that she loved me...\n I felt like a zombie that night.";
			gt.transform.localPosition=new Vector3(0.177f,1.0f,20.01f);
			gt.text = yazi;
		} else if (name == "3") {
			yazi="My grand son.\n In fact,\n if he’s still alive,\n he will be my grand son.\n He was sick.\n Sick a lot than here ı am.\n I tried to help him, but...\n I can’t afford money, to keep him alive. ";
			gt.text = yazi;
			gt.transform.localPosition=new Vector3(0.177f,0.46f,20.01f);
			
		}
	}


	
	

	void OnMouseExit()
	{
		Debug.Log ("bbbbbbbb");
		on = false;
	
	}
	void OnMouseUpAsButton() {
		Debug.Log ("cccccccccccc");
		string name = gameObject.name;
		if (name == "1") {
			Application.LoadLevel("Baby");
				} else if (name == "2") {
			Application.LoadLevel("Ergen");
				} else if (name == "3") {
			Application.LoadLevel("MiddleAge");

				}
	}

	}

