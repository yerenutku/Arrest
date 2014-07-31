using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
		CharacterController CC;
		float horizantalSpeed = 8.0f;
		Animation Runright;
		public Material mt;
		public Texture[] textures;
		private int indis = 0;
		public Texture[] textureleft;
		public Texture LeftStand;
		public Texture RightStand;
		public int framecounter = 0;
		bool right = true;
		bool firstmover = true;
		bool firstmovel = true;
	AudioSource walk;

		// Use this for initialization
		void Start ()
		{
				if (rigidbody)
						rigidbody.freezeRotation = true;
				CC = GetComponent<CharacterController> ();
		walk = GetComponent<AudioSource> ();

				




	

		}
	
		// Update is called once per frame
		void Awake ()
		{
				Application.targetFrameRate = 60;
		}

		void Update ()
		{ 
				CC.Move (Physics.gravity);
	
				framecounter++;

	
				if (Input.GetKey ("right")) {
						CC.Move (Vector3.right * horizantalSpeed * Time.deltaTime + Physics.gravity);
			if(!walk.isPlaying){
				walk.Play();}
						right = true;
						if (firstmover) {
								firstmovel = true;

								mt.mainTexture = textures [0];
								firstmover = false;
						} else {
						
								if ((framecounter) % 8 == 0) {
				
										indis += 1;
										indis = indis % textures.Length;
										mt.mainTexture = textures [indis];
								}
						}
			

				} else if (Input.GetKey ("left")) {
						right = false;
			if(!walk.isPlaying){
				walk.Play();}
				
		
						CC.Move (Vector3.left * horizantalSpeed * Time.deltaTime + Physics.gravity);
						if (firstmovel) {
								firstmover = true;

								mt.mainTexture = textureleft [0];
								firstmovel = false;

						} else {
								if ((framecounter) % 8 == 0) {
										indis += 1;
										indis = indis % textures.Length;
										mt.mainTexture = textureleft [indis];
								}
						}
		
				} else {
				
					if(right)
				{
				mt.mainTexture=RightStand;

				}
			else{
				mt.mainTexture=LeftStand;
			}
		
		}


		}
}
