using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
      public void PlayGame()
    {
        SceneManager.LoadScene(""); 
        //se vogliamo passare invece alla prossima scena perch� numerate allora scriviamo 
        //SceneManager.GetActiveScene().buildIndex + 1 
        //le scene si numerano nel build settings di unity 
    }
}
