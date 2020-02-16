using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScore : MonoBehaviour
{
    public float globalScore;

    // Start is called before the first frame update
    void Start()
    {
        globalScore = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        globalScore++;
    }
}
