using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManage : MonoBehaviour
{

    [Header("Player Variables")]

    public GameObject Player1;
    public GameObject Player2;
    public TMP_Text PlayerText1;
    public TMP_Text PlayerText2;
    public GameObject PlayerTextObject1;
    public GameObject PlayerTextObject2;

    [Header("Player Inputs")]

    public string Player1Action = "asd";
    public string Player2Action = ",./";

    [Header("Game Variables")]

    public bool GameStart;
    public bool GameEnd;
    public TMP_Text BaseText1;
    public int Player1Points = 0;
    public int Player2Points = 0;


    void Start()
    {
        StartCoroutine(GameTimer(1f));

       string Char1 = "";
       Char1 = (string)Player1Action[Random.Range(0, Player1Action.Length)].ToString();


    }

    // Update is called once per frame
    void Update()
    {
      
           int CombinationSelect1 = Random.Range(0, 2 + 1);

       string ActionButton1 = Char1[CombinationSelect1];
       //ActionButton1.ToString();

       if (GameStart)
       {
              if (Input.GetKeyDown(ActionButton1)){print("Hi");}
       }

    }

    private IEnumerator GameTimer(float WaitTime)
    {
        float RandomTime = Random.Range(3f, 10f + 1f);
        Debug.Log("Intermission: " + RandomTime);
        yield return new WaitForSeconds(RandomTime);
        Debug.Log("Duel Active");
        BaseText1.text = "Duel!";
        PlayerTextObject1.SetActive(true);
        PlayerTextObject2.SetActive(true);
        PlayerText1.text = Player1Action;
        PlayerText2.text = Player2Action;
        GameStart = true;
    }
}

        // Char1;
        // Char1 = Player1Action[Random.Range(0, Player1Action.Length)];
        //int CombinationSelect1 = Random.Range(0, 2 + 1);
        // int CombinationSelect2 = Random.Range(0, 2 + 1);
        //string ActionButton1 = Char1[CombinationSelect1];
        //comboIndex += 1;