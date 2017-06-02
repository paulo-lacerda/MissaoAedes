using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CronometroRepelente : MonoBehaviour {

	// Use this for initialization

	public Player player;
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

		Cronometro ();
		
	}

	public void Cronometro(){
	
		float tempoRestante = 5.0f;

		tempoRestante -= Time.deltaTime;
		if (tempoRestante < 0) {

			player.ativarRepelente = false;


		}
	
	}
}
