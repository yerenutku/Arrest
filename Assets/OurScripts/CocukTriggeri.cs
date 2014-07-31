using UnityEngine;
using System.Collections;

public class CocukTriggeri : MonoBehaviour {
	public  bool KidIsAlive=true; 
	public GameObject ilackutusu;
	public GameObject cocukolu;
	public GameObject cocukhayatta;
	DoorOpener DOR;
	public GameObject evkapisi;
	public AudioSource Anases;
	AudioSource olum;
	int i=0;
	// Use this for initialization
	void Start () {
		ilackutusu.SetActive (false);
		DOR = evkapisi.GetComponent<DoorOpener> ();
		olum = GetComponent<AudioSource> ();

	
	}
	
	// Update is called once per frame
	void Update () {

	if (KidIsAlive) {
						if (DOR.Interior) {
				
								cocukhayatta.SetActive (true);
								cocukolu.SetActive (false);
		
						}
			else{


				cocukhayatta.SetActive (false);
				cocukolu.SetActive (false);
			}
				} else {
			if(DOR.Interior){
				Debug.Log ("ana muzigi kesip olum girdi");
				Anases.Stop();
				if(!olum.isPlaying && i==0)
				{olum.Play();
					Invoke("wait",25.0f);}

			cocukhayatta.SetActive (false);
				cocukolu.SetActive (true);}
			else{
				cocukhayatta.SetActive (false);
				cocukolu.SetActive (false);
			}
				}
	}
	void OnTriggerStay()
	{

		if (KidIsAlive) {
				
			Debug.Log ("cocuk hap istiyor");
			ilackutusu.SetActive (true);


						//hapresmi cocuk balonuna ulasıcak

		
				} else {
			ilackutusu.SetActive (false);

			Debug.Log("cocuk oldu");
			//ekran karar oyunu bitir;
				}


	}
	void OnTriggerExit()
	{

		ilackutusu.SetActive (false);


	}
	void wait(){
		Application.LoadLevel("finish");
	}
}
