using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tuto : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PopTuto;
    public int PopNow;
    public GameObject popup;
    void Start()
    {
        PopNow = 1;
        PopTuto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopTutoActivate()
    {
        if (PopNow == 1)
        {
            popup.SetActive(false);
            PopTuto.SetActive(true);
            PopNow = 2;
        }
        else if (PopNow == 2)
        {
            PopTuto.SetActive(false);
            PopNow = 1;
        }

    }
}
