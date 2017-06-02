using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FocoDengue : MonoBehaviour {

	[SerializeField]
	private float barraVida;

	[SerializeField]
	private Image conteudo;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D(Collision2D colisor){
	
		if (colisor.gameObject.tag == "PlayerNormal") {


			Destroy(gameObject);
			conteudo.fillAmount -= 0.3f;
		
		}

	}

}
