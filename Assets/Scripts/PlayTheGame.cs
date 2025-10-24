using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayTheGame : MonoBehaviour
{
    public Button Play;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button PlayButton = Play.GetComponent<Button>();
        PlayButton.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() { SceneManager.LoadScene("MainGame"); }
}
