using UnityEngine;
using System.Collections;

public class BacivanScript : MonoBehaviour {
	public bool Paraveren=false;
	public bool BahcivanActive=false;
	public GameObject Eczaci;
	EczacıTriggeri ET;
	public GameObject Yaprak1;
	public GameObject Yaprak2;
	public GameObject Yaprak3;
	YaprakScriti  YS1;
	YaprakScriti  YS2;
	YaprakScriti  YS3;
	public GameObject dia;
	public GameObject dolar;
	// Use this for initialization
	void Start () {
		ET = Eczaci.GetComponent<EczacıTriggeri> ();
		YS1 = Yaprak1.GetComponent<YaprakScriti> ();
		YS2 = Yaprak2.GetComponent<YaprakScriti> ();
		YS3= Yaprak3.GetComponent<YaprakScriti> ();
		dia.SetActive (false);
		dolar.SetActive (false);



	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay()
	{

		if (BahcivanActive) {

			Debug.Log("aaaaaa");
						if (!Paraveren) {
				dia.SetActive(true);
				dolar.SetActive(false);

				Debug.Log("yapraklar aktive edildi toplana bilir");
				YS1.YaprakAktive=true;
				YS2.YaprakAktive=true;
				YS3.YaprakAktive=true;
		
						} else {
				dia.SetActive(false);
				dolar.SetActive(true);

								//eczaciyi degistir
				Debug.Log("eczacı artık ilac veriyiot");
				ET.giver=true;

						}
				}

	}
	void OnTriggerExit(){

		dia.SetActive(false);
		dolar.SetActive(false);



	}
}
