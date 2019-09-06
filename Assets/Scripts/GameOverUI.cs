using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverUI : MonoBehaviour {

    GameObject ResultScore;
    GameObject ResultCombo;


  
	void Start () {
        this.ResultScore= GameObject.Find("ResultScore");
        this.ResultCombo= GameObject.Find("ResultCombo");

    }

    private void Update()
    {
        ResultScore.GetComponent<Text>().text = "Score:" + UIController.score;
        ResultCombo.GetComponent<Text>().text = "Combo:" + UIController.Combo;
    }
    public void ReturnTitle()
    {
        UIController.score = 0;
        UIController.Combo = 0;
        SceneManager.LoadScene("Title");
        GameObject.Find("SoundManager").GetComponent<SoundController>().StopBGM1();

    }
    public void Exit()
    {
        Application.Quit();
    }
}
