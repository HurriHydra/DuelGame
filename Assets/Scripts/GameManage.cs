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

    public KeyCode Player1Action;
    public KeyCode Player2Action;

    [Header("Game Variables")]

    public bool GameStart;
    public TMP_Text BaseText1;
    public bool Player1Win = false;
    public bool Player2Win = false;


    void Start()
    {
        StartCoroutine(GameTimer(1f));
    }

    // Update is called once per frame
    void Update()
    {
       if (GameStart)
       {
         if (Input.GetKeyDown(Player1Action)){print("Player 1 Wins"); GameStart = false; Player2.SetActive(false); PlayerTextObject2.SetActive(false); BaseText1.text = "PLAYER 1 WINS"; StartCoroutine(EndGame(3f)); }

         if (Input.GetKeyDown(Player2Action)){print("Player 2 Wins"); GameStart = false; Player1.SetActive(false); PlayerTextObject1.SetActive(false); BaseText1.text = "PLAYER 2 WINS"; StartCoroutine(EndGame(3f)); }
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
        GameStart = true;
        int RandomChoice1 = Random.Range(0, 3);
        int RandomChoice2 = Random.Range(0, 3);

        switch (RandomChoice1)
        {
            case 0:
                Player1Action = KeyCode.A;
                PlayerText1.text = "A";
            break;

            case 1:
                Player1Action = KeyCode.W;
                PlayerText1.text = "W";
            break;

            case 2:
                Player1Action = KeyCode.S;
                PlayerText1.text = "S";
            break;

            case 3:
                Player1Action = KeyCode.D;
                PlayerText1.text = "D";
            break;
        }

        switch (RandomChoice2)
        {
            case 0:
                Player2Action = KeyCode.UpArrow;
                PlayerText2.text = "UP";
            break;

            case 1:
                Player2Action = KeyCode.DownArrow;
                PlayerText2.text = "DOWN";
            break;

            case 2:
                Player2Action = KeyCode.LeftArrow;
                PlayerText2.text = "LEFT";
            break;

            case 3:
                Player2Action = KeyCode.RightArrow;
                PlayerText2.text = "RIGHT";
            break;
        }

    }

    private IEnumerator EndGame(float WaitTime)
    {

        Debug.Log("hi ending game now");
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene("Menu");

    }
}


