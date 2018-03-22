using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour {

	public static GamePlayController instance;

	[SerializeField]
	private Button instructionButton;

	[SerializeField]
	private Text scoreText, endScoreText, bestScoreText;

	[SerializeField]
	private GameObject gameOverPanel, pausePanel;

	void Awake(){
		Time.timeScale = 0;
		_MakeInstance ();
	}

	void _MakeInstance(){
		if (instance == null) {
			instance = this;
		}
	}
		
	public void _InstructionButton(){
		Time.timeScale = 1;
		instructionButton.gameObject.SetActive (false);
	}

	public void _SetScore(int score){
		scoreText.text = "" + score;//hoặc scoreText.text = score.ToString();
	}

	public void _BirdDiedShowPanel(int score){
		gameOverPanel.SetActive (true);
		endScoreText.text = "" + score;
		if(score > GameManager.instance._GetHighScore()){
			GameManager.instance._SetHighScore (score);
		}
		bestScoreText.text = "" + GameManager.instance._GetHighScore();
	}

	public void _MenuButton(){
		SceneManager.LoadScene ("MainMenu");//Chuyển đến màn hình MainMenu
	}

	public void _RestartGameButton(){
		SceneManager.LoadScene ("GamePlay");//Trở về màn hình GamePlay = use command Application.LoadLevel("GamePlay")
		//Application.LoadLevel(Application.loadedLevel);//Trở về màn hình Level hiện tại (Vd chết lv3 chơi lại màn 3)
	}

	public void _PauseButton(){
		Time.timeScale = 0;
		pausePanel.SetActive (true);
	}

	public void _ResumeButton(){
		Time.timeScale = 1;
		pausePanel.SetActive (false);
	}
}
