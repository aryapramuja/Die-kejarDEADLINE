using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour{

	// public string mainMenuLevel;

	// public void RestartGame(){
	// 	FindObjectOfType<GameManager>().Reset();
	// }

	// public void QuitToMain(){
	// 	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	// 	// Application.LoadLevel(mainMenuLevel);
	// }

	void FixedUpdate(){
        if (Input.GetKeyDown(KeyCode.F)) {
            SceneManager.LoadScene(0);
        }
    }

}	