using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneRestart : MonoBehaviour {
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}