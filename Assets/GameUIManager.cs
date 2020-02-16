using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    GameObject button;
    GameObject winText;
    GameObject lostText;

    void Start()
    {
        button = GameObject.Find("RetryButton");
        winText = GameObject.Find("WinText");
        lostText = GameObject.Find("LostText");

        button.SetActive(false);
        winText.SetActive(false);
        lostText.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
