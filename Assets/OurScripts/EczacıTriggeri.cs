using UnityEngine;
using System.Collections;

public class EczacıTriggeri : MonoBehaviour {
	public bool giver=false;
	public GameObject cocuk;
	CocukTriggeri CT;
	public GameObject Bahcivan;
	BacivanScript BCS;
	public GameObject Door;
	DoorOpener DOS;
	public Texture ilacverme;
	public Texture paraisteme;
	public Material mt;
	GameObject balon;
	public Texture dollar;
	public Texture hap;
	public Material bmt;
	public Texture ilac;
	public Material eczakutusu;

	// Use this for initialization
	void Start () {
		CT = cocuk.GetComponent<CocukTriggeri> ();
		BCS = Bahcivan.GetComponent<BacivanScript> ();
		DOS = Door.GetComponent<DoorOpener>();
		balon = transform.GetChild (0).gameObject;
		balon.SetActive (false);
		eczakutusu.mainTexture=dollar;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay()
	{
		if (DOS.Interior) {
			Debug.Log("içerdeysek");
			//commend resim göster
			if (giver) {
				mt.mainTexture=ilacverme;
								//İlacı verme
								CT.KidIsAlive = false;
								Debug.Log ("cocugu oldurdu");
				eczakutusu.mainTexture=ilac;
				//ilaci verme resme

				balon.SetActive(true);
		
		
						} else {
					    
								BCS.BahcivanActive = true;
								Debug.Log ("bahcıvan aktive edildi,para istiyo");
								//para istiyor
				mt.mainTexture=paraisteme;
				eczakutusu.mainTexture=dollar;
				balon.SetActive(true);
				//para resmi

						}

				}

	}
	void OnTriggerExit()
	{
		balon.SetActive (false);

	}
}
