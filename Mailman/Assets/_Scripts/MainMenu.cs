using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	private Vector2 startTopLeft;
	private Vector2 midPos;
	private Vector2 quitBotLeft;
	private Camera cameraloc;

	// Use this for initialization
	void Start () {
		startTopLeft = new Vector2 (-10f, 5f);
		quitBotLeft = new Vector2 (-10f, -5f);
		midPos = new Vector2 (-10f, 0f);
	}
	
	// Update is called once per frame
	void Update () {

		Rect startBounds = new Rect(0, 0, Screen.width, Screen.height/3 * 2);
		Rect quitBounds = new Rect(0, 0, Screen.width, Screen.height/3);
	}
}
