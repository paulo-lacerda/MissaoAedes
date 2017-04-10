using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	 public void play(){
	
		Application.LoadLevel ("c1");
	
	}

	public void sair(){

		Application.Quit ();
	}

}
