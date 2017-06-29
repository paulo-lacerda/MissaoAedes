using UnityEngine;
using System.Collections;

public class Itens : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter2D(Collision2D colisor)
	{
		if (colisor.gameObject.tag == "PlayerNormal" || colisor.gameObject.tag == "PlayerRepelente")
		{
	
		
			Destroy(this, 5f);
		}
	}
}
