using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour{

	public Text scoreText;
	public Text hiScoreText;

	public float scoreCount;
	public float hiScoreCount;

	public float pointPerSecond;

	public bool scoreIncreasing;



	void Start(){
		if((int)PlayerPrefs.GetFloat("HighScore") != 0){
		 	hiScoreCount = PlayerPrefs.GetFloat("HighScore");
		}
	}

	void Update(){

		if(scoreIncreasing){	
			scoreCount += pointPerSecond * Time.deltaTime;
		}

		if(scoreCount > PlayerPrefs.GetFloat("HighScore")){
			hiScoreCount = scoreCount;
			PlayerPrefs.SetFloat("HighScore", scoreCount);
		}

		scoreText.text = "Skor: " + Math.Round(scoreCount);
		hiScoreText.text = "Skor Tertinggi: " + Math.Round(hiScoreCount);
	}

}