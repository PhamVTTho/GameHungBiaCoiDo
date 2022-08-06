using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Game : MonoBehaviour
{
    [SerializeField] private GameObject spawnStation;
    [SerializeField] private GameObject gameOver_System;
    [SerializeField] private GameObject BeerPrefabs;
    [SerializeField] private Score_Count score_Count;
    [SerializeField] private Heart_controller heart_Controller;
    [SerializeField] private Beer_AutoSpawn beer_AutoSpawn;

    public void restartClicked()
    {
        PlayerPrefs.DeleteAll();
        BeerPrefabs.GetComponent<Beer_Controller>().beerSpeed = 1f;
        beer_AutoSpawn.loopEnable = true;
        score_Count.score = 0;
        heart_Controller.heart = 3;
        PlayerPrefs.SetInt("Player_Heart", 3);
        spawnStation.SetActive(true);
        SceneManager.LoadScene(1);
    }
}
