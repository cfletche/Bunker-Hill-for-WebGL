using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActivate02 : MonoBehaviour
{
    void OnMouseDown()
    {
GameObject.Find("CanvasPanels").transform.Find("Panel 02").gameObject.SetActive(true);   
 }
    }
