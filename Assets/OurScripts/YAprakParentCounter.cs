using UnityEngine;
using System.Collections;

public class YAprakParentCounter : MonoBehaviour {
	public int counter=0;
	GameObject bahci;
	BacivanScript BS;
	// Use this for initialization
	void Start () {
		bahci = transform.parent.gameObject;
		BS = bahci.GetComponent<BacivanScript> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	if (counter == 3) {
				
		//bahçivanı degistir
			Debug.Log("bahcıvan para verdi");
			BS.Paraveren=true;
		
		}
	}
}
