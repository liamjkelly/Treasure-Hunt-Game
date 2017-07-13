using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Treasure : MonoBehaviour {

	public GameObject igloo, player;
	public Text winningText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.transform.position, igloo.transform.position) < 10f) {
			winningText.text = "You found your igloo! Press SPACE to go inside!";
			if (Input.GetKeyDown(KeyCode.Space)) {
				winningText.text = "Congratulations! You found your igloo and can take shelter!";
				player.transform.position = new Vector3(igloo.transform.position.x, igloo.transform.position.y - (igloo.transform.position.y + 10f), igloo.transform.position.z);
			}
		}
	}
}
