using UnityEngine;
using System.Collections;

public class DogGrap : MonoBehaviour {
	MeshRenderer mr;
	public bool dogcarry=false;
	public GameObject grave;
	GraveYardCapture GYC;
	public GameObject canlikopek;
	// Use this for initialization
	void Start () {
		GYC = grave.GetComponent<GraveYardCapture> ();
		canlikopek.SetActive(false);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay()
	{
	if (GYC.openeddig) {
						if (Input.GetKey ("space")) {
								dogcarry = true;
				canlikopek.SetActive(false);
				transform.gameObject.SetActive(false);
				

						}
				}
		if (!dogcarry) {
			canlikopek.SetActive(true);

				}

	}
	void OnTriggerExit()
	{
		canlikopek.SetActive(false);

	}
}
