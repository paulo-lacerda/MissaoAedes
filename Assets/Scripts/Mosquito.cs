using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mosquito : MonoBehaviour
{

	// Use this for initialization

	public bool esquerda;
	public float velocidade;
	public float delay;
	public float tempoMovimento;

	[SerializeField]
	private float barraVida;

	[SerializeField]
	private Image conteudo;



	void Start ()
	{
	}
	// Update is called once per frame
	void Update ()
	{

		Movimentar ();
	}

	void OnCollisionEnter2D (Collision2D colisor)
	{

		if (colisor.gameObject.tag == "PlayerNormal") {
			conteudo.fillAmount -= 0.3f;
		}

		if (colisor.gameObject.tag == "PlayerRepelente") {
			Destroy (gameObject);
		}
	}

	void Movimentar ()
	{

		tempoMovimento += Time.deltaTime;

		if (tempoMovimento <= delay) {


			if (esquerda) {

				transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
			} else {

				transform.Translate (-Vector2.left * velocidade * Time.deltaTime);

			}
		} else {

			esquerda = !esquerda;

			tempoMovimento = 0;
		}
	}
}
