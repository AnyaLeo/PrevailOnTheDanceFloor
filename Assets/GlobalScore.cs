using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScore : MonoBehaviour
{
    public int globalScore;
    public int numberOfNpcs; 
    public bool mainPlayerFell;
    public bool win;
    GameObject retryButton;
    GameObject winText;
    GameObject lostText;

    // Start is called before the first frame update
    void Start()
    {
        globalScore = 0;
        mainPlayerFell = false;

        retryButton = GameObject.Find("RetryButton");
        winText = GameObject.Find("WinText");
        lostText = GameObject.Find("LostText");
    }

    // Update is called once per frame
    void Update()
    {
        if(numberOfNpcs == globalScore)
        {
            setWin();
        }
    }

    public void IncrementScore()
    {
        globalScore++;
    }

    public void setMainMainPlayerFell()
    {
        mainPlayerFell = true;
        retryButton.SetActive(true);
        lostText.SetActive(true);
    }

    public void setWin()
    {
        win = true;
        retryButton.SetActive(true);
        winText.SetActive(true);
    }
}
