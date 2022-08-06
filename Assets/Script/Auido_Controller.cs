using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auido_Controller : MonoBehaviour
{
    [SerializeField] AudioSource mainSound;
    [SerializeField] AudioClip audioClip;
    [SerializeField] public bool audioTriger = false;
    void Update()
    {
        if(audioTriger == true)
        {
            mainSound.GetComponent<AudioSource>();
            mainSound.PlayOneShot(audioClip);
        }
    }
}
