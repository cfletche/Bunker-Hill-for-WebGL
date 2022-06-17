using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActivate01 : MonoBehaviour
{
    void OnMouseDown()
    {
GameObject.Find("CanvasPanels").transform.Find("Panel 01").gameObject.SetActive(true);   
 }
    }
