using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeHolder : MonoBehaviour {

	public float speed;
	
	// Update is called once per frame
	void Update () {
		if (BirdController.instance.flag != null) {
			if (BirdController.instance.flag == 1) {
				Destroy (GetComponent<PipeHolder> ());
			}
		}
		_PipeMovement ();
	}

	void _PipeMovement(){
		Vector3 temp = transform.position;
		temp.x -= speed * Time.deltaTime;
		transform.position = temp;
	}

	//void OnCollisionEnter2D(Collision2D target){ //sử dụng khi hai đối tượng va chạm không check ô Is Trigger
	void OnTriggerEnter2D(Collider2D target){	//sử dụng khi 1 in 2 đối tượng va chạm được check ô Is Trigger
		if (target.tag == "Destroy") {
			Destroy (gameObject);
		}
	}
}
