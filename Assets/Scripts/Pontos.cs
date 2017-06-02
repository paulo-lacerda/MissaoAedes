using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour {

	// Use this for initialization
	public static int pontos;

	public static Pontos instancia;

	public GUIText txt;

	void Awake(){

		instancia = this;
	
	}


	void Start () {

		txt = gameObject.GetComponent<GUIText> ();
	
		txt.text = "Pontos: " + pontos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AdicionarPontos(int _ponto){ 
		pontos += _ponto;
		txt.text = "Pontos:  " + pontos;

	}

	public static void Inicializar(){
		pontos = 0;
	}
}
