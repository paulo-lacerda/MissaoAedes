using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	 public void play(){

		SceneManager.LoadScene ("PlayerSelect");
	
	}
	public void playBoy(){

		SceneManager.LoadScene ("CBoy1");

	}
	public void playGirl(){

		SceneManager.LoadScene ("CGirl1");

	}

	public void MenuPrincipal(){

		SceneManager.LoadScene ("MenuPrincipal");
	}

	public void sair(){

		Application.Quit ();
	}

}
