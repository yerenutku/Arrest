using UnityEngine;
using System.Collections;

public class Depoopener : MonoBehaviour {
	public GameObject key;
	KeyUp KU; 
	bool open=false;
	//KürekGrap kg;
	public GameObject kürek;
	bool firsttouch=true;
	AudioSource lockd;
	AudioSource unlock;

	bool ışık=false;
	public GameObject spotcan;
	public GameObject direkabi;
	// Use this for initialization
	void Start () {
		KU = key.GetComponent<KeyUp> ();
		lockd = GetComponent<AudioSource> ();
		unlock = transform.GetChild (0).transform.gameObject.GetComponent<AudioSource> ();
		direkabi = GameObject.Find ("Directional light");

		//kg=kürek.GetComponent<KürekGrap>();

	}
	
	// Update is called once per frame
	void Update () {
				if (open) {
				
						if (Input.GetKeyDown ("space") && firsttouch) {
								unlock.Play ();
								kürek.SetActive (true);
								GameObject Ext = transform.parent.GetChild (1).gameObject;
								Ext.SetActive (false);
								GameObject inte = transform.parent.GetChild (2).gameObject;
								inte.SetActive (true);
								firsttouch = false;




						}


				} 

		
		
				}
		
	

	void OnTriggerStay()
	{
		if (KU.keygetted) {

						open = true;
			if(Input.GetKeyUp("space")){
			if (!ışık) {
				Debug.Log("spot aktif");
				spotcan.light.intensity=7f;
				direkabi.light.intensity=0f;
			
			}
			if (ışık) {
				Debug.Log("söz direkte");
				spotcan.light.intensity=0f;
				direkabi.light.intensity=0.5f;

			}
				ışık=!ışık;}
				} else {

			if(Input.GetKeyUp("space"))
			{

				if(!lockd.isPlaying)
					lockd.Play();

			}

				}



	}

}