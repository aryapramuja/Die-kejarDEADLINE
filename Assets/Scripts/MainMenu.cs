using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// public string playGameLevel;

	// public void PlayGame(){
	// 	SceneManager.LoadScene(playGameLevel);
	// 	// Application.LoadLevel(playGameLevel);
	// }

	void FixedUpdate(){
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene(1);
        }
    }
}