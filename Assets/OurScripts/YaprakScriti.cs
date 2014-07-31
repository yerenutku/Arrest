using UnityEngine;
using System.Collections;

public class YaprakScriti : MonoBehaviour {
	public bool YaprakAktive=false;
	bool FirstTouch=true;
	YAprakParentCounter YPC;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay()
	{
		if (YaprakAktive) {
				
			if(Input.GetKeyDown("space")&&FirstTouch)
			   {
				//yaprakları yok et yaprak annesinde countır atrtırr 3 olursa bahcıvanı degistir
				GameObject P= transform.parent.gameObject;

				YPC=P.GetComponent<YAprakParentCounter>();
				YPC.counter++;
				FirstTouch=false;
				transform.gameObject.SetActive(false);



			}
		
		}

	}
}
