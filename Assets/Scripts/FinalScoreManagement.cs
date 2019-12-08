using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FinalScoreManagement : MonoBehaviour
{
    public Text finalScore;
    private float finalScoreCount=0;
    private float highScoreCount=0;

    // Start is called before the first frame update
    void Start()
    {
    	if((int)PlayerPrefs.GetFloat("Score") != 0){
				finalScoreCount = PlayerPrefs.GetFloat("Score");
			}
		if((int)PlayerPrefs.GetFloat("HighScore") != 0){
				highScoreCount = PlayerPrefs.GetFloat("HighScore");
			}
		finalScore.text = "Skor kamu: " + Math.Round(finalScoreCount);
    	if((int)PlayerPrefs.GetFloat("Score") == (int)PlayerPrefs.GetFloat("HighScore")){
    		finalScore.text = finalScore.text + "\nSelamat kamu mencetak skor tertinggi baru!";
    	}
    	else{
    		finalScore.text = finalScore.text + "\nSkor tertinggi: " + Math.Round(highScoreCount);
    	}

    }

    // Update is called once per frame
    void Update()
    {

    }
}