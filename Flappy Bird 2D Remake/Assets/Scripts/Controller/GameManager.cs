﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	private const string HIGHT_SCORE = "High Score";

	void Awake(){
		_MakeSingleInstance ();
		IsGameStartedForTheFirstTime ();
	}

	void IsGameStartedForTheFirstTime(){
		if (!PlayerPrefs.HasKey ("IsGameStartedForTheFirstTime")) {
			PlayerPrefs.SetInt (HIGHT_SCORE, 0);
			PlayerPrefs.SetInt ("IsGameStartedForTheFirstTime", 0);
		}
	}

	void _MakeSingleInstance(){
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	public void _SetHighScore(int score){
		PlayerPrefs.SetInt (HIGHT_SCORE, score);
	}

	public int _GetHighScore(){
		return PlayerPrefs.GetInt (HIGHT_SCORE);
	}
}
