using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PopShop;
    public int PopNow;
    void Start()
    {
        PopNow = 1;
        PopShop.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopUpActivate()
    {
        if (PopNow == 1)
        {
            PopShop.SetActive(true);
            PopNow = 2;
        }
        else if (PopNow == 2)
        {
            PopShop.SetActive(false);
            PopNow = 1;
        }

    }
}
