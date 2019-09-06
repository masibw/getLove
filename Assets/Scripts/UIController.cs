using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{

    public static int score = 0;
    public static int Combo = 0;
    GameObject scoreText;
    GameObject gameOverText;
    GameObject ComboText;


    public void AddScore()
    {
        Combo += 1;
        score += 10 + Combo * Combo;
        
       
    }

    // Use this for initialization
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
        this.ComboText = GameObject.Find("Combo");
        
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D7");
        ComboText.GetComponent<Text>().text = "Combo:" + Combo.ToString("D3");
    }
}