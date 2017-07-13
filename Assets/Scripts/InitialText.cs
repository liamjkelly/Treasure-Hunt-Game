using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialText : MonoBehaviour {

	public Text hintText;
	// Use this for initialization
	void Start () {
		hintText.text = "You are a penguin who has lost his igloo. You see something to the Northwest that could help you!\n\n Use WASD to move around";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
