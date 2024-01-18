using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoclickThird : MonoBehaviour
{
    public Button upgradeButtonThird;

    public ScoreManager scoreManager;
    //public int clickPower;
    public int clickPowerThird;
    public float timeBetClick = 1;
    public int AchatThird = 2;
    private double Money;

    void Start()
    {

        AchatThird = 2;
        clickPowerThird = 75;
        upgradeButtonThird.onClick.AddListener(UpgradeThird);
    }

    private IEnumerator AutoClickerThird()
    {
        while (true)
        {
            scoreManager.RiseScoreThird(clickPowerThird);
            yield return new WaitForSeconds(timeBetClick);
        }
    }

    public void UpgradeThird()
    {
        scoreManager.AchatThirds();

    }

    public void LaunchAutoclickThird()
    {
        StartCoroutine(AutoClickerThird());

    }


}
