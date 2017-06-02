using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mosquito : MonoBehaviour {

	// Use this for initialization

	[SerializeField]
	private float barraVida;

	[SerializeField]
	private Image conteudo;



	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D (Collision2D colisor){

		if(colisor.gameObject.tag == "PlayerNormal"){
			conteudo.fillAmount -= 0.3f;
		}

		if (colisor.gameObject.tag == "PlayerRepelente") {
			Destroy (gameObject);
		}


	}
}
