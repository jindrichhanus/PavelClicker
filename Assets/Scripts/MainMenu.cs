using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool isLoading = false;
    public void NewGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        isLoading = true;
        SceneManager.LoadScene(2);
    }


}
