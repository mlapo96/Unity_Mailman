using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class startButton : MonoBehaviour {

	SpriteRenderer sprite;
	private Button start;

	// Use this for initialization
	void Start () {
		start = GetComponent<Button> ();
		start.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("click");
		SceneManager.LoadScene ("Main");
	}
}
