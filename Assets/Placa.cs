using UnityEngine;
using System.Collections;

public class Placa : MonoBehaviour {

	// Use this for initialization

	public SpriteRenderer sprender;

	void Start () {

		sprender.enabled = false;

	
	}
	
	// Update is called once per frame
	void Update () {

		esconder ();
	
	}


	void esconder(){

		sprender = gameObject.GetComponent<SpriteRenderer> ();


	}


	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			sprender.enabled = true;

			Destroy(gameObject, 6f);

			
		
		} 
	}



}
