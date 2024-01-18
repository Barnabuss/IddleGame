using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModifieText : MonoBehaviour
{
    //public ScoreManager monScoreManager;
    public TextMeshProUGUI monUI;
    public int Money;
    public ScoreManager scoreManager;
    public int clickPower;


    private void Start()
    {
    }

    private void OnMouseDown()
    {
        scoreManager.RiseScore(1);
    }



}
