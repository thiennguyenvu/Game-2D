using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //khai báo trước khi sử dụng cú pháp SceneManager.LoadScene("");

public class MainMenuController : MonoBehaviour {

	public void _PlayButton(){
		//Application.LoadLevel ("GamePlay");//tương tự cú pháp SceneManager.LoadScene() nhưng là cú pháp khai báo cũ của Unity
		SceneManager.LoadScene("GamePlay");//cú pháp tải màn hình qua các level game.
	}
}
