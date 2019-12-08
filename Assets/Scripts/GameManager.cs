using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	private ScoreManager theScoreManager;

	void Start () {
		// Skor
		theScoreManager = FindObjectOfType<ScoreManager>();
	}

	void Update () {

	}

}