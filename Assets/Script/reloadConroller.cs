﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class reloadConroller : MonoBehaviour
{
    private AudioSource audioSource;
    void Start(){
        audioSource = GameObject.Find("button_s").GetComponent<AudioSource>();
    } 
    public void OnLoginButtonCLick(){
        audioSource.Play();
        SceneManager.LoadScene("first"); 
        roundController.round = 1;
        roundController.score = 0;
        roundController.score1 = 0;
        roundController.score2 = 0;
        roundController.score3 = 0;
        textController.total = 0;
    }
}
