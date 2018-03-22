using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		Vector3 tempScale = transform.localScale;
		float height = sr.bounds.size.y;
		float width = sr.bounds.size.x;

		float spaceHeight = Camera.main.orthographicSize * 2f; //10
		float spaceWidth = spaceHeight * Screen.width/Screen.height; 

		tempScale.y = spaceHeight / height;
		tempScale.x = spaceWidth / width;
		transform.localScale = tempScale;
	}
}
