using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    public Canvas displayIntroUI;
    public void Start()
    {
        displayIntroUI.enabled = true;
    }

    public void loadLevel()
    {
        SceneManager.LoadScene("firstLevel");
    }
    public void loadMenu()
    {
        SceneManager.LoadScene("introMenu");
    }
    public void loadInstructions()
    {
        SceneManager.LoadScene("instructionMenu");
    }public void loadInstructions2()
    {
        SceneManager.LoadScene("instructionMenu2");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
