using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    GameObject button;
    void Start()
    {
        button = GameObject.Find("RetryButton");
        button.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
