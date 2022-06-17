using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Controls : MonoBehaviour
{
    //Aerial View
    public Camera cam;
    public float camX;
    public float camY;
    public float camZ;
    private bool down;

    //Current LA
    private bool laOff;

    //Movement
    public float transformspeed;
    public float rotatespeed;


    // Start is called before the first frame update
    void Start()
    {
        //Aerial View
        down = true;

        //Current LA
        laOff = true;

        //Movement
        transformspeed = 20;
        rotatespeed = 75;
    }

    // Update is called once per frame
    void Update()
    {

        //Aerial View
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (down)
            {
                cam = GetComponent<Camera>();
                camX = transform.position.x;
                camY = transform.position.y;
                camZ = transform.position.z;
                cam.transform.localPosition = new Vector3(camX, camY + 30, camZ);
                cam.GetComponent<Rigidbody>().useGravity = false;
                down = false;
            }
            else
            {
                cam = GetComponent<Camera>();
                cam.transform.localPosition = new Vector3(camX, camY, camZ);
                cam.GetComponent<Rigidbody>().useGravity = true;
                down = true;
            }
            
        }

        //Current LA
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (laOff)
            {
                GameObject.Find("Current LA").transform.Find("Downtown_LA").gameObject.SetActive(true);
                laOff = false;
            }
            else
            {
                GameObject.Find("Current LA").transform.Find("Downtown_LA").gameObject.SetActive(false);
                laOff = true;
            }
            
        }

        //Movement
        transform.Translate(0f, 0f, Input.GetAxis("Vertical") * Time.deltaTime * transformspeed);
        transform.Rotate(0f, Input.GetAxis("Horizontal") * Time.deltaTime * rotatespeed, 0f);

        //Quit Game
        if (Input.GetKeyDown(KeyCode.Q))
            Application.Quit();

        //Scene Restart
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
