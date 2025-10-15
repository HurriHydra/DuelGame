using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManage : MonoBehaviour
{

    public GameObject Player1;
    public GameObject Player2;
    public TMP_Text PlayerText1;
    public TMP_Text PlayerText2;

    public TMP_Text BaseText1;



    void Start()
    {
        StartCoroutine(GameTimer(1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GameTimer(float WaitTime)
    {
        float RandomTime = Random.Range(3f, 10f + 1f);
        Debug.Log("Intermission: " + RandomTime);
        yield return new WaitForSeconds(RandomTime);
        Debug.Log("Duel Active");
        BaseText1.text = "Duel!";
    }
}
