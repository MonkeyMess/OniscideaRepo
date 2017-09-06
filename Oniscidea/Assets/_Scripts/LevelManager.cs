using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    public string initiateGame;
    public void PlayGame()
    {
        //Application.LoadLevel(initiateGame);
        SceneManager.LoadScene(initiateGame);
    }
    public void Options()
    {

    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {

    }

    public void SetFullScreen(bool isFullScreen)
    {

    }
}
