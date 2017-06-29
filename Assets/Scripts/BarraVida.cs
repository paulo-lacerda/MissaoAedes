using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraVida : MonoBehaviour {

	// Use this for initialization

	public Animator anim;


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

		if (conteudo.fillAmount == 0) {
		
			//SceneManager.LoadScene ("MenuPrincipal");
			anim.SetTrigger("morrer");

			Debug.Log ("MORREU");

			SceneManager.LoadScene ("GameOver");
		}

		
	}

	public void barra(){
		
		if (reduzir == true) {

			conteudo.fillAmount -= 0.005f;

		}

	}
		
}
