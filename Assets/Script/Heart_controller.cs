using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_controller : MonoBehaviour
{
    [SerializeField] private GameObject heart1_object, heart2_object, heart3_object;
    [SerializeField] private Sprite heartLose;
    [SerializeField] private Sprite heartDefault;
    [SerializeField] public int heart = 3;
    [SerializeField] public GameObject gameOverSystem;
    [SerializeField] public GameObject spawnStation;
    void Start()
    {
        PlayerPrefs.SetInt("Player_Heart", 3);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("Player_Heart") == 3)
        {
            heart3_object.GetComponent<SpriteRenderer>().sprite = heartDefault;
            heart2_object.GetComponent<SpriteRenderer>().sprite = heartDefault;
            heart1_object.GetComponent<SpriteRenderer>().sprite = heartDefault;
        }

        if (PlayerPrefs.GetInt("Player_Heart") == 2)
        {
            heart3_object.GetComponent<SpriteRenderer>().sprite = heartLose;
        }
        if(PlayerPrefs.GetInt("Player_Heart") == 1)
        {
            heart3_object.GetComponent<SpriteRenderer>().sprite = heartLose;
            heart2_object.GetComponent<SpriteRenderer>().sprite = heartLose;
        }
        if (PlayerPrefs.GetInt("Player_Heart") == 0)
        {
            heart3_object.GetComponent<SpriteRenderer>().sprite = heartLose;
            heart2_object.GetComponent<SpriteRenderer>().sprite = heartLose;
            heart1_object.GetComponent<SpriteRenderer>().sprite = heartLose;
            spawnStation.SetActive(false);
            gameOverSystem.SetActive(true);
        }
    }
}
