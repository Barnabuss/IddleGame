using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public Slider miiBar;
    public float Money;
    public float MoneySpe;
    private double AchatUi;
    public GameObject Mii;
    public GameObject MiiMatt;
    public GameObject WiiWheel;
    public GameObject WiiFitTrainer;
    public Transform parent;

    public TextMeshProUGUI monUI;
    public TextMeshProUGUI monUISpe;
    public TextMeshProUGUI monUIAchat;
    public TextMeshProUGUI monUIAchatSec;
    public TextMeshProUGUI monUIAchatThird;
    public TextMeshProUGUI monUIAchatTube;
    public TextMeshProUGUI monUITube;
    public TextMeshProUGUI monUIAchatClick;
    public TextMeshProUGUI monUIAchatClickSpe;
    public Autoclick autoclick;
    public AutoclickSecond autoclickSec;
    public AutoclickThird autoclickThird;
    public int LimitMoney;
    public int BonusClick = 0;
    public int BonusSpe = 1;
    public int Achat = 50;
    public int AchatSec = 300;
    public int AchatThird = 2;
    public int AchatTube = 5;
    public int AchatClick = 300;
    public int AchatClickSpe = 4;

    public Autoclick myAutoClk;
    public Autoclick myAutoClkSec;
    public Autoclick myAutoClkThird;
    // Start is called before the first frame update
    void Start()
    {
        BonusClick = 0;
        Achat = 50;
        AchatSec = 300;
        AchatThird = 2;
        AchatTube = 5;
        AchatClick = 300;
        AchatClickSpe = 4;
        LimitMoney = 500;
    }

    // Update is called once per frame
    void Update()
    {
        miiBar.value = Money;
        monUI.text = "" + Money;
        monUISpe.text = "" + MoneySpe;
        miiBar.maxValue = LimitMoney;
        if (Money >= LimitMoney)
        {
            Money = Money - LimitMoney;
            MoneySpe += BonusSpe;
            miiBar.maxValue = LimitMoney;
        }
    }


    public void RiseScore(int click)
    {
        Money += click;
        Instantiate(MiiMatt, new Vector3(6.219116f, 5.828247f, 0), Quaternion.identity);
    }

    public void RiseScoreSec(int click)
    {
        Money += click;
        Instantiate(WiiWheel, new Vector3(6.219116f, 5.828247f, 0), Quaternion.identity);
    }

    public void RiseScoreThird(int click)
    {
        Money += click;
        Instantiate(WiiFitTrainer, new Vector3(6.219116f, 5.828247f, 0), Quaternion.identity);
    }



    public void Click()
    {
        Money++;
        Money += BonusClick;
        Instantiate(Mii, new Vector3(6.219116f, 5.828247f, 0), Quaternion.identity);
    }
    public void AchatFirst()
    {
        if (Achat <= Money)
        {
            if(Achat == 50)
            {
                autoclick.LaunchAutoclick();
            }
            Achat += 50;
            Money -= Achat;
            if (Money <= 0)
            {
                Money = 0;
            }
            autoclick.clickPower++;
            monUIAchat.text = "" + Achat;
        }
        else
        {
            print("No !");
        }

        

    }


    public void AchatSecond()
    {
        if (AchatSec <= Money)
        {
            if(AchatSec == 300)
            {
                autoclickSec.LaunchAutoclickSec();
            }
            AchatSec += 150;
            Money -= AchatSec;
            if (Money <= 0)
            {
                Money = 0;
            }
            autoclickSec.clickPowerSec++;
            monUIAchatSec.text = "" + AchatSec;
        }
        else
        {
            print("No 2!");
        }

        

    }

    public void AchatThirds()
    {
        if (AchatThird <= MoneySpe)
        {
            if (AchatThird == 2 )
            {
                autoclickThird.LaunchAutoclickThird();
            }
            AchatThird += 6;
            MoneySpe -= AchatThird;
            if (MoneySpe <= 0)
            {
                MoneySpe = 0;
            }
            autoclickThird.clickPowerThird++;
            monUIAchatThird.text = "" + AchatThird;
        }
        else
        {
            print("No 3!");
        }



    }

    public void UpTube()
    {
        if (AchatTube <= MoneySpe)
        {
            LimitMoney += 500;
            AchatTube += 5;
            BonusSpe += 2 ;
            MoneySpe -= AchatTube;
            if (MoneySpe <= 0)
            {
                MoneySpe = 0;
            }
            
            monUIAchatTube.text = "" + AchatTube;
            monUITube.text = "Capacity : " + LimitMoney;
        }
        else
        {
            print("No 4!");
        }

        
    }

    public void MoreClick()
    {
        if (AchatClickSpe <= MoneySpe && AchatClick <= Money)
        {
            
            Money -= AchatClick;
            MoneySpe -= AchatClickSpe;
            AchatClick += 300;
            AchatClickSpe += 4;
            BonusClick += 4;
            if (MoneySpe <= 0)
            {
                MoneySpe = 0;
            }
            if (Money <= 0)
            {
                Money = 0;
            }

            monUIAchatClick.text = "" + AchatClick;
            monUIAchatClickSpe.text = "" + AchatClickSpe;
        }
        else
        {
            print("No 5!");
        }


    }





}
