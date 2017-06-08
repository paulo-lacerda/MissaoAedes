using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaVoadora : MonoBehaviour {

	// Use this for initialization

	public bool esquerda;
	public float velocidade;
	public float delay;

	public float tempoPlataforma; 
	public float delayPlataforma;

	public float tempoMovimento;




	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Movimentar ();

	}


	void Movimentar(){

		tempoMovimento += Time.deltaTime;

		if (tempoMovimento <= delay) {
		
		
			if (esquerda) {
			
				transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
			} 

			else {

				transform.Translate ( -Vector2.left * velocidade * Time.deltaTime);
			}

		}
		
					else{

						esquerda = !esquerda;
						tempoMovimento = 0;
					}

	}
}
