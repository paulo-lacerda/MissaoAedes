using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FocoDengue : MonoBehaviour {

	public Transform plataformavoadora;

	[SerializeField]
	private float barraVida;

	[SerializeField]
	private Image conteudo;

	public int adicionar = 1;
	public Pontos pontos;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnCollisionEnter2D(Collision2D colisor){
	
		if (colisor.gameObject.tag == "PlataformaVoadora") {
		
			transform.SetParent (parent: plataformavoadora);

		}


		if (colisor.gameObject.tag == "PlayerNormal" || colisor.gameObject.tag == "PlayerRepelente") {


			pontos.AdicionarPontos ();

			Destroy(gameObject);


		
		}

	}

}
