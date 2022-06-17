using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
public float transformspeed;
public float rotatespeed;

    // Start is called before the first frame update
    void Start()
    {
        transformspeed = 20;
		rotatespeed = 75;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (0f,0f,Input.GetAxis("Vertical")*Time.deltaTime*transformspeed);
		transform.Rotate (0f,Input.GetAxis("Horizontal")*Time.deltaTime*rotatespeed,0f);
    }
}