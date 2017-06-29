using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta : MonoBehaviour {

	// Use this for initialization

	public Pontos pontos;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (pontos.pontos);
		
	}


	void OnCollisionEnter2D(Collision2D colisor)
	{
		if (pontos.pontos >3  && colisor.gameObject.tag == "PlayerNormal" || colisor.gameObject.tag == "PlayerRepelente")
		{
		
			SceneManager.LoadScene ("Curiosidade1");
		
		}
	}


}
