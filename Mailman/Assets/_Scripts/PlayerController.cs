using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb;
	private SpriteRenderer player;
	private Animator ani;
	private Collider2D coll;
	private Collider2D coll2;
	private Collision2D collision;
    private AudioSource aud;

	private bool isGround = true;
	private float fallZone = -20f;
	private Vector3 spawn;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		player = GetComponent<SpriteRenderer> ();
		ani = GetComponent<Animator> ();
		coll = GetComponent<Collider2D> ();
        aud = GetComponent<AudioSource>();

		coll = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
		coll2 = GameObject.FindGameObjectWithTag("background").GetComponent<Collider2D>();

		spawn = new Vector3 (-2.2f, -1.7f, -2);
	}

	void Update (){

		if (Input.GetKeyDown (KeyCode.Space) && isGround == true) {
            rb.AddForce(new Vector2(0, 1500));
            aud.Play();
			ani.SetBool ("isJump", true);
		}

		if (transform.position.y < fallZone) {
			transform.position = spawn;
			rb.velocity = new Vector2 (0, 0);
		}
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");

		rb.AddForce(Vector2.right * 160 * moveHorizontal);	

		if (Input.GetAxis("Horizontal") < 0) {
			player.flipX = true;
			ani.SetBool ("isMoving", true);
		} 

		if (Input.GetAxis("Horizontal") > 0) {
			player.flipX = false;
			ani.SetBool ("isMoving", true);
		}

		if (Input.GetAxis("Horizontal") == 0) {
			ani.SetBool ("isMoving", false);
		}
	}	

	void OnCollisionEnter2D (Collision2D other) 
	{
		ani.SetBool ("isJump", false);
		isGround = true;
	}

	void OnCollisionExit2D (Collision2D other) 
	{
		ani.SetBool ("isJump", true);
		isGround = false;
	}

}