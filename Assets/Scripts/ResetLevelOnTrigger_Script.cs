using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using UnityEngine.UI; //Uncomment if using a loseScreen
// using TMPro; //Uncomment if using a loseScreen

public class ResetLevelOnTrigger_Script : Monobehavior
{
    //public GameObject loseScreen; //Uncomment if using a loseScreen

    
    void Start()
    {
        // Time.timeScale = 1; //Uncomment if using a loseScreen
        // loseScreen.SetActive(false); //Uncomment if using a loseScreen
    }
    
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other) 
    {
      if (other.gameObject.tag == "Player") 
      {
           SceneManager.LoadScene(0); //Comment out if using a loseScreen

        //    loseScreen.SetActive(true); //Uncomment if using a loseScreen vvv
        //    Time.timeScale = 0;
        //    Cursor.visible = true;
        //    Cursor.lockState = CursorLockMode.None;
       }
  }
}