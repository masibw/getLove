using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    public GameObject SoundManager;

    public AudioClip BGM1;//backgroundmusic
    public AudioClip GetHeart;//Getheart SE

    private AudioSource audioSource;
    int BGMFlg = 1;


    private void Awake()
    {
        DontDestroyOnLoad(SoundManager);

        audioSource = gameObject.GetComponent<AudioSource>();

    }

    public void StartBGM1(){
    audioSource.clip = BGM1;
        audioSource.Play();
        BGMFlg = 1;
    }

    public void StartGetHeart()
    {
        audioSource.PlayOneShot(GetHeart);
    }
    public void StopBGM1()
    {
        audioSource.Stop();
    }
}

        
    
