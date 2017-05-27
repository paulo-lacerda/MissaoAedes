using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

// Use this for initialization
	public Transform player;
	public int velocidade = 20;
	public Animator anim;
	public Rigidbody2D rb2d;
	public LayerMask plataforma;
	public Vector2 pontoColisao = Vector2.zero;
	public bool estaNoChao;
	public float raio;
	public Color debugColisao = Color.red;
	public float forcaPulo = 300;


	void Start ()
	{



		rb2d = GetComponent<Rigidbody2D> ();
		anim = player.GetComponentInChildren<Animator> ();
	}

// Update is called once per frame
	void Update ()
	{
		
		Movimentar ();
		EstaNoChao ();
		ControlarEntradas ();
	}






	private void EstaNoChao ()
	{
		var pontoPosicao = pontoColisao;
		pontoPosicao.x += transform.position.x;
		pontoPosicao.y += transform.position.y;
		estaNoChao = Physics2D.OverlapCircle (pontoPosicao, raio, plataforma);
	}






	private void Movimentar ()
	{

		anim.SetFloat ("andar", Mathf.Abs (Input.GetAxis ("Horizontal")));

		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
		}

		if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);
		}

	}




	private void Pular()
	{
		if (estaNoChao) 
		{

			rb2d.AddForce(new Vector2(0,forcaPulo));

			anim.SetTrigger("pulando");

		}
	}


	private void ControlarEntradas()
	{
		if(Input.GetButtonDown("Jump"))
		   {
			Pular();
		}
	}



	void OnDrawGizmos()
	{
		Gizmos.color = debugColisao;
		var pontoPosicao = pontoColisao;
		pontoPosicao.x += transform.position.x;
		pontoPosicao.y += transform.position.y;
		estaNoChao = Physics2D.OverlapCircle (pontoPosicao, raio, plataforma);
		Gizmos.DrawWireSphere (pontoPosicao, raio);
	}


}














