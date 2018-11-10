using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //public GameObject gull;
    Vector3 spawn = new Vector3(8, 0, -8);
    Vector3 current_pos = new Vector3();
    float fly_speed = 0.02f;
    private SpriteRenderer sprite;
    private AudioSource aud;


    // Use this for initialization
    void Start () {
        transform.position = spawn;
        current_pos.x = spawn.x;
        current_pos.y = spawn.y;
        sprite = GetComponent<SpriteRenderer>();
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {

        // Fly off left side
        if(current_pos.x < -9){
            fly_speed *= -1;
            current_pos.y = Random.Range(-3.0f, 4.2f);
            sprite.flipX = false;
            aud.Play();
        }

        // Fly off right side
        if (current_pos.x > 9){
            fly_speed *= -1;
            current_pos.y = Random.Range(-3.0f, 4.2f);
            sprite.flipX = true;
            fly_speed += 0.005f;
            aud.Play();
        }
        current_pos.x -= fly_speed;
        current_pos.z = -8;
        transform.position = current_pos;
	}
}
