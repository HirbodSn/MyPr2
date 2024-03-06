using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panelswıiching : MonoBehaviour
{
    public GameObject Panel1, Panel2, Panel3;
    public void OpenPage1()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
    }
    public void OpenPage2()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(true);
        Panel3.SetActive(false);
    }
    public void OpenPage3()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(true);
    }
}
