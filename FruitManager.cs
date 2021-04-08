using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{

    public Text levelCleared;

    public GameObject transition;

    public Text totalFruits;

    public Text fruitsCollected;

    private int totalFruitsInLevel;

    private void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }

    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();
    }

    public void AllFruitsCollected()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("No quedan frutas, Victoria");
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangesScene", 1);
            
        }
    }

    public void Pass()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
        {
            PlayerPrefs.SetInt("levelsUnlocked", currentLevel + 1);
        }
    }

    void ChangesScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
