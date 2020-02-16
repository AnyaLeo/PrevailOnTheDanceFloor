using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScore : MonoBehaviour
{
    public float globalScore;
    public bool mainPlayerFell;
    public bool win;

    // Start is called before the first frame update
    void Start()
    {
        globalScore = 0f;
        mainPlayerFell = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        globalScore++;
    }

    public void setMainMainPlayerFell()
    {
        mainPlayerFell = true;
    }

    public void setWin()
    {
        win = true;
    }
}
