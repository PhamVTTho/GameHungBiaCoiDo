using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Count : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] public int score;
    [SerializeField] public GameObject background;
    [SerializeField] public Sprite background_Default1, background_Default2, background_Default3;
    [SerializeField] public Sprite background1_1, background2_1, background3_1;
    [SerializeField] public Sprite background1_2, background2_2, background3_2;
    [SerializeField] public Sprite background1_3, background2_3, background3_3;
    [SerializeField] public Beer_AutoSpawn beer_AutoSpawn;
    [SerializeField] public GameObject beerPrefabs;
    void Start()
    {
        if(PlayerPrefs.GetInt("Player_Choose") == 1)
        {
            background.gameObject.GetComponent<SpriteRenderer>().sprite = background_Default1;
        }
        if (PlayerPrefs.GetInt("Player_Choose") == 2)
        {
            background.gameObject.GetComponent<SpriteRenderer>().sprite = background_Default2;
        }
        if (PlayerPrefs.GetInt("Player_Choose") == 3)
        {
            background.gameObject.GetComponent<SpriteRenderer>().sprite = background_Default3;
        }
    }

    void Update()
    {
        scoreText.SetText("Điểm : " + score);
        if(score == 10)
        {
            if (PlayerPrefs.GetInt("Player_Choose") == 1) ;
            {
            background.gameObject.GetComponent<SpriteRenderer>().sprite = background1_1;
            background.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            beerPrefabs.GetComponent<Beer_Controller>().beerSpeed = 2f;
            }
            if (PlayerPrefs.GetInt("Player_Choose") == 2)
            {
                background.gameObject.GetComponent<SpriteRenderer>().sprite = background2_1;
                background.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                beerPrefabs.GetComponent<Beer_Controller>().beerSpeed = 2f;
            }
            if (PlayerPrefs.GetInt("Player_Choose") == 3)
            {
                background.gameObject.GetComponent<SpriteRenderer>().sprite = background3_1;
                background.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                beerPrefabs.GetComponent<Beer_Controller>().beerSpeed = 2f;
            }
        }
        if (score == 20)
        {
            if(PlayerPrefs.GetInt("Player_Choose") == 1)
            {
                background.gameObject.GetComponent<SpriteRenderer>().sprite = background1_2;
                background.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                beer_AutoSpawn.spawnTime = 3f;
                beerPrefabs.GetComponent<Beer_Controller>().beerSpeed = 3f;
            }
            if (PlayerPrefs.GetInt("Player_Choose") == 2)
            {
                background.gameObject.GetComponent<SpriteRenderer>().sprite = background2_2;
                background.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                beerPrefabs.GetComponent<Beer_Controller>().beerSpeed = 3f;
            }
            if (PlayerPrefs.GetInt("Player_Choose") == 3)
            {
                background.gameObject.GetComponent<SpriteRenderer>().sprite = background3_2;
                background.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                beerPrefabs.GetComponent<Beer_Controller>().beerSpeed = 3f;
            }

        }
        if (score == 30)
        {
            if (PlayerPrefs.GetInt("Player_Choose") == 1)
            {
                background.gameObject.GetComponent<SpriteRenderer>().sprite = background1_3;
                background.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                beer_AutoSpawn.spawnTime = 2f;
            }
            beerPrefabs.GetComponent<Beer_Controller>().beerSpeed = 4f;
            if (PlayerPrefs.GetInt("Player_Choose") == 2)
            {
                background.gameObject.GetComponent<SpriteRenderer>().sprite = background2_3;
                background.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                beerPrefabs.GetComponent<Beer_Controller>().beerSpeed = 4f;
            }
            if (PlayerPrefs.GetInt("Player_Choose") == 3)
            {
                background.gameObject.GetComponent<SpriteRenderer>().sprite = background3_3;
                background.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                beerPrefabs.GetComponent<Beer_Controller>().beerSpeed = 4f;
            }
        }
    }
}
