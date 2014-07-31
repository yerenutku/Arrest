using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject Character;
	// Use this for initialization
	void Start () {
		float z;
		z = Character.transform.localPosition.z - 2.5f;
		transform.localPosition.Set (Character.transform.localPosition.x, 13.62408f, z);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Character.transform.localPosition.x < -28.0f || Character.transform.localPosition.x > 37.0f) {
				}
		else
		{
			   transform.localPosition=Character.transform.localPosition+new Vector3(0.0f,10.2f,-2.5f);

		}
		

	}
}
