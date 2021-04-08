using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    //public SceneFader sceneFader;
    public void StartGame()
    {
        //sceneFader.FadeTo(levelToLoad);
        SceneManager.LoadScene("Level1");
    }
    public void LevelGame()
    {
        //sceneFader.FadeTo(levelToLoad);
        SceneManager.LoadScene("LevelSelect");
    }
    
}
