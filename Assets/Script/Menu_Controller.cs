using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{

   public void onFirstBackgroundClicked()
    {
        PlayerPrefs.SetInt("Player_Choose", 1);
        SceneManager.LoadScene(0);
    }
    public void onSecondBackgroundClicked()
    {
        PlayerPrefs.SetInt("Player_Choose", 2);
        SceneManager.LoadScene(0);
    }
    public void onThirdBackgroundClicked()
    {
        PlayerPrefs.SetInt("Player_Choose", 3);
        SceneManager.LoadScene(0);
    }
}
