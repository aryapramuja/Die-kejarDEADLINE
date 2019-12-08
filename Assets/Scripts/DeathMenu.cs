using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour{

	void FixedUpdate(){
		// Memulai ulang permainan dengan menekan tombol F
        if (Input.GetKeyDown(KeyCode.F)) {
            SceneManager.LoadScene(0);
        }
    }

}	