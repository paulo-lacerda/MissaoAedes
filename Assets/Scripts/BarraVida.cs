using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {

	// Use this for initialization

	[SerializeField]
	private float barraVida;

	[SerializeField]
	private Image conteudo;

	public bool reduzir = false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		barra ();

		Debug.Log (conteudo.fillAmount);
		if (conteudo.fillAmount == 0) {
		
			Debug.Log ("MORREU");
		}

		
	}

	public void barra(){
		
		if (reduzir == true) {

			conteudo.fillAmount -= 0.005f;

		}

	}
		
}
