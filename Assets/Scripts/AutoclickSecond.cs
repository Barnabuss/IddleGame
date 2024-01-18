using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoclickSecond : MonoBehaviour
{
    public Button upgradeButtonSec;

    public ScoreManager scoreManager;
    //public int clickPower;
    public int clickPowerSec;
    public float timeBetClick = 1;
    public int AchatSec = 300;
    private double Money;

    void Start()
    {
        
        AchatSec = 300;
        clickPowerSec = 10;
        upgradeButtonSec.onClick.AddListener(UpgradeSec);
    }
    
    private IEnumerator AutoClickerSec()
    {
        while (true)
        {
            scoreManager.RiseScoreSec(clickPowerSec);
            yield return new WaitForSeconds(timeBetClick);
        }
    }

    public void UpgradeSec()
    {
            scoreManager.AchatSecond();
        
    }

    public void LaunchAutoclickSec()
    {
        StartCoroutine(AutoClickerSec());

    }


}
