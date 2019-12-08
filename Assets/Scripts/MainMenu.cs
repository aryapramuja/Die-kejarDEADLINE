using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	void FixedUpdate(){
        // Memulai Permainan dengan menekan tombol Spasi
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene(1);
        }
        // Mengatur ulang Skor Tertinggi dengan tombol Q
        if (Input.GetKeyDown(KeyCode.Q)) {
            PlayerPrefs.SetFloat("HighScore", 0);
        }
    }
}