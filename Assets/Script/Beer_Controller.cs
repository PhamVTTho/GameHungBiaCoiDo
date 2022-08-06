using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Beer_Controller : MonoBehaviour
{
    private GameObject scoreCount;
    private GameObject heart_Controller;
    private GameObject sound_Controller;
    [SerializeField] public float beerSpeed = 1f;

    private void Start()
    {
        scoreCount = GameObject.FindGameObjectWithTag("System");
        heart_Controller = GameObject.FindGameObjectWithTag("System");
        sound_Controller = GameObject.FindGameObjectWithTag("System");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Beer_Crate")
        {
            sound_Controller.GetComponent<AudioSource>().Play();
            scoreCount.GetComponent<Score_Count>().score++;
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "End_Colider")
        {
            PlayerPrefs.SetInt("PLayer_Heart", heart_Controller.GetComponent<Heart_controller>().heart--);
            if (heart_Controller.GetComponent<Heart_controller>().heart == 2)
            {
                PlayerPrefs.SetInt("Player_Heart", 2);
            }
            if (heart_Controller.GetComponent<Heart_controller>().heart == 1)
            {
                PlayerPrefs.SetInt("Player_Heart", 1);
            }
            if (heart_Controller.GetComponent<Heart_controller>().heart == 0)
            {
                PlayerPrefs.SetInt("Player_Heart", 0);
                PlayerPrefs.SetInt("Player_Destroy_Object", 1);
            }
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        this.gameObject.transform.Translate(Vector2.down * beerSpeed * Time.deltaTime);
    }
}
