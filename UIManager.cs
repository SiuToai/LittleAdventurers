using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UIManager : MonoBehaviour
{

    private int currentSceneIndex;

    public AudioSource clip;

    public static bool isGamePaused = false;
    [SerializeField] GameObject pauseMenu;

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void AnotherOptions()
    {
        //Sound
        //Graphics
    }
    public void SavedGame()
    {
        Time.timeScale = 1;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadScene("MainMenu");
    }
    
    
    public void GoLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelSelect");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlatSoundButton()
    {
        clip.Play();
    }
}
