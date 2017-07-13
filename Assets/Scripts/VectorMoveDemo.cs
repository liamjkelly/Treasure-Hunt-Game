using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMoveDemo : MonoBehaviour {


	// Update is called once per frame
	void Update () {

		// GetKeyDown and GetKeyUp refer to instant motion, good for tapping things
		// GetKey for holding down
		if (Input.GetKey(KeyCode.W)) { //moves forward if press [W]
			//moved cube while ignoring rotation
			//transform.position += new Vector3 (0f, 0f, 1f);

			//move cube while following rotation
			transform.Translate(0f, 0f, 1f);
		}

		if (Input.GetKey(KeyCode.S)) { //moves backward if press [S]
			//moved cube while ignoring rotation
			//transform.position += new Vector3 (0f, 0f, -1f);

			//move cube while following rotation
			transform.Translate(0f, 0f, -1f);
		}

		if (Input.GetKey(KeyCode.A)) {
			transform.Rotate (0f, -15f, 0f); // rotate 15 degrees left on y-axis if [A] is held
		}

		if (Input.GetKey(KeyCode.D)) {
			transform.Rotate (0f, 15f, 0f); // rotate 15 degrees right on y-axis if [D] is held
		}
	}
}
