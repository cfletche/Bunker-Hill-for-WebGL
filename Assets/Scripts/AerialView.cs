using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AerialView : MonoBehaviour {
	public Camera cam;
	public float camX;
	public float camY;
	public float camZ;
	
	
	
	void Update () {
       
			if (Input.GetKeyDown(KeyCode.U))
		{
			
			cam = GetComponent<Camera>();
			camX = transform.position.x;
			camY = transform.position.y;
			camZ = transform.position.z;
			cam.transform.localPosition = new Vector3(camX,camY + 30,camZ);
			cam.GetComponent<Rigidbody>().useGravity = false;
	}
			if (Input.GetKeyDown(KeyCode.D))
		{
			
			cam = GetComponent<Camera>();
			cam.transform.localPosition = new Vector3(camX,camY,camZ);
			cam.GetComponent<Rigidbody>().useGravity = true;
	}
}
}