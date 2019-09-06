using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartController : MonoBehaviour
{

    float fallSpeed;



    private void Start()
    {
        this.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        this.fallSpeed = 0.05f + 0.1f * Random.value;
      



    }


    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        

        if (transform.position.y < -20.5f)
        {
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
           
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
            GameObject.Find("SoundManager").GetComponent<SoundController>().StartGetHeart();
            Destroy(gameObject);
            
        }
    }

   
}

