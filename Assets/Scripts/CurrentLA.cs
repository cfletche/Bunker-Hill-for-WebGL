using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CurrentLA : MonoBehaviour {
	

	
	void Update () {
        if (Input.GetKeyDown(KeyCode.L))
		{
			GameObject.Find("Current LA").transform.Find("Downtown_LA").gameObject.SetActive(true); 
	}
		if (Input.GetKeyDown(KeyCode.A))
		{
			GameObject.Find("Current LA").transform.Find("Downtown_LA").gameObject.SetActive(false);
	}
		
}
}