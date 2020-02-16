using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScore : MonoBehaviour
{
    public int globalScore;
    public int numberOfNpcs; 
    public bool mainPlayerFell;
    public bool win;
    GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        globalScore = 0;
        mainPlayerFell = false;

        button = GameObject.Find("RetryButton");
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
        button.SetActive(true);
    }

    public void setWin()
    {
        win = true;
        button.SetActive(true);
    }
}
