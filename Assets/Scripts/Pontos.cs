using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour {

	// Use this for initialization
	public  int pontos;

	public static Pontos instancia;

	public Text txt;

	public int ponto =2;

	void Awake(){

		instancia = this;
	
	}


	void Start () {


		AdicionarPontos ();
		
		txt.text = " " + pontos;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void AdicionarPontos(){ 
		pontos=pontos +1;
		txt.text = " " + pontos;

	}


}
