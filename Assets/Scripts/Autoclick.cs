using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Autoclick : MonoBehaviour
{
    public Button upgradeButton;

    public ScoreManager scoreManager;
    //public int clickPower;
    public int clickPower;
    public float timeBetClick = 1;
    public int Achat;
    private double Money;

    void Start()
    {
        
        Achat = 50;
        clickPower = 1;
        upgradeButton.onClick.AddListener(Upgrade);
    }
    
    private IEnumerator AutoClicker()
    {
        while (true)
        {
            scoreManager.RiseScore(clickPower);
            yield return new WaitForSeconds(timeBetClick);
        }
    }

    public void Upgrade()
    {
            scoreManager.AchatFirst();
        
    }

    public void LaunchAutoclick()
    {
        StartCoroutine(AutoClicker());

    }


}
