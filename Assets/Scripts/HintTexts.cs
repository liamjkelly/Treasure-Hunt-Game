using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintTexts : MonoBehaviour {

	public GameObject player, fish, researchNotes, researcher;
	public Text hintText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Vector3.Distance(player.transform.position, fish.transform.position) < 5f) { //checks if first clue found
			hintText.text = "This fish is pointed to the East. Better see what's over there.";
		}

		if (Vector3.Distance (player.transform.position, researchNotes.transform.position) < 5f) { //checks if second clue found
			hintText.text = "These notes talk about a research station to the South. Maybe they know something.";
		}

		if (Vector3.Distance (player.transform.position, researcher.transform.position) < 5f) { //checks if third clue found
			hintText.text = "The researcher thanks you for returning his notes. He says that your igloo is to the Southwest, but he's also confused. His notes say you don't live in an igloo. " +
				"What does he know?";
		}
			
	}
}
