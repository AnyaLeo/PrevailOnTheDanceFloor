using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    private float latestDirectionChangeTime;
    public float directionChangeTime = 3f;


    // Start is called before the first frame update
    void Start()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        GetComponent<Renderer>().material.color = newColor;

        latestDirectionChangeTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);

        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            GetComponent<Renderer>().material.color = newColor;
            latestDirectionChangeTime = Time.time;
        }
    }
}
