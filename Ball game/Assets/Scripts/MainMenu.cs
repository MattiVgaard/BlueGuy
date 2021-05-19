using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuUI;

    public GameObject levelsUI;
    // Update is called once per frame

    public void StartGame()
    {
        SceneManager.LoadScene("Minigame");
        Time.timeScale = 1f;
    }

    public void LoadLevels()
    {
        mainMenuUI.SetActive(false);
        levelsUI.SetActive(true);
    }
    
    public void LoadOptions()
    {
        
    }

    public void QuitMenu()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    
    public void Level1()
    {
        SceneManager.LoadScene("Minigame");
        Time.timeScale = 1f;
    }
    
    public void Level2()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1f;
    }
    
    public void Level3()
    {
        SceneManager.LoadScene("Level 2");
        Time.timeScale = 1f;
    }
    
    public void BackToManin()
    {
        mainMenuUI.SetActive(true);
        levelsUI.SetActive(false);
    }
}
