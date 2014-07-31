using UnityEngine;
using System.Collections;

public class GraveYardCapture : MonoBehaviour {
	public GameObject kurek;
	KürekGrap kg;
	public bool openeddig=false;
	DogGrap DG;
	public GameObject Dog;
	AudioSource Dig;
	public GameObject Character;
	Move M;
	public Material Cukur;
	public Texture saydam;
	public Texture cukur;
	public Texture mezar;
	bool firsttouch=true;
	bool firsttouch2=true;

	// Use this for initialization
	void Start () {
		kg = kurek.GetComponent<KürekGrap> ();
		DG = Dog.GetComponent<DogGrap> ();
		Dig = GetComponent<AudioSource> ();
		M = Character.GetComponent<Move> ();
		Cukur.mainTexture = saydam;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Dig.isPlaying) {
			M.enabled=false;
				
		
				} else {
				
			M.enabled=true;
		}
	
	}
	void OnTriggerStay()
	{
				if (kg.kürekcarry) {
						if (Input.GetKeyDown ("space") && firsttouch){
		//graveyard açma
				Dig.Play();
				Debug.Log("çukur açtı");
				openeddig=true;
				Cukur.mainTexture=cukur;
				firsttouch=false;

						}
		
				}
		if (DG.dogcarry && openeddig && firsttouch2) {
			if (Input.GetKeyDown ("space")){
				Dig.Play();
				Cukur.mainTexture=mezar;
				Debug.Log("kopugu gomdu ");
				firsttouch2=false;
				Invoke("wait",3.0f);


			}
		
		}

		}
	void wait()
	{
		Application.LoadLevel("StartScene");

	}
}
