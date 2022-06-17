using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class QuitGame : MonoBehaviour {
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
            Application.Quit();
	}
}