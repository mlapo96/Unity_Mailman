using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class exitButton : MonoBehaviour {

	SpriteRenderer sprite;
	private Button exit;

	// Use this for initialization
	void Start () {
		exit = GetComponent<Button> ();
		exit.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("click");
		Application.Quit ();
	}
}
