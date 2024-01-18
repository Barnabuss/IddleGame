using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeClick : MonoBehaviour
{
    // Start is called before the first frame update
    public ScoreManager scoreManager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpgradeClickPower()
    {
        scoreManager.MoreClick();

    }
}
