using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text;

public class MainMenu : MonoBehaviour {

    public string playLevel;

    public void StartGame() {
        SceneManager.LoadScene(playLevel);
    }

    public void StartGameWithBia()
    {
        Debug.Log("Menu bia");
        GlobalVars.isRicardinho = false;
        SceneManager.LoadScene(playLevel);
    }

    public void StartGameWithRicardinho()
    {
        Debug.Log("Menu ricardinho");
        GlobalVars.isRicardinho = true;
        SceneManager.LoadScene(playLevel);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
