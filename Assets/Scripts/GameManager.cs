using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	/*
	public Transform platformGenerator;
	private vector3 platformStartPoint;
	*/

	public Player thePlayer;
	// private vector3 playerStartPoint;

	// private PlatformDestroyer[] platformList;

	private ScoreManager theScoreManager;

	public DeathMenu theDeathScreen;

	void Start () {
		// platformStartPoint = platformGenerator.position;
		// playerStartPoint = thePlayer.transform.position;

		theScoreManager = FindObjectOfType<ScoreManager>();
	}

	void Update () {

	}

	public void RestartGame(){
		theScoreManager.scoreIncreasing = false;
		thePlayer.gameObject.SetActive(false);

		theDeathScreen.gameObject.SetActive(true);

		// StartCoroutine ("RestartGameCo");
	}

	public void Reset (){
		theDeathScreen.gameObject.SetActive(true);

		// platformList = FindObjectOfType<PlatformDestroyer>();
		
		// for(int i = 0; i<platformList.Length; i++){
		// 	platformList[i].gameObject.SetActive(false);
		// }
		
		
		// thePlayer.transform.position = playerStartPoint;
		// platformGenerator.position = platformStartPoint;
		thePlayer.gameObject.SetActive(true);

		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
	}

	
	// public IEnumerator RestartGameCo(){
	// 	theScoreManager.scoreIncreasing = false;
	// 	thePlayer.gameObject.SetActive(false);
	// 	yield return new WaitForSeconds(0.5f);
	// 	// platformList = FindObjectOfType<PlatformDestroyer>();
		
	// 	// for(int i = 0; i<platformList.Length; i++){
	// 	// 	platformList[i].gameObject.SetActive(false);
	// 	// }
		

	// 	thePlayer.transform.position = playerStartPoint;
	// 	// platformGenerator.position = platformStartPoint;
	// 	thePlayer.gameObject.SetActive(true);

	// 	theScoreManager.scoreCount = 0;
	// 	theScoreManager.scoreIncreasing = true;
	// }
	

}