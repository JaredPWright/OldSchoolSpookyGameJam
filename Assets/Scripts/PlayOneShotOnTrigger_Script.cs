using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayOneShotOnTrigger_Script : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>(); //If you prefer to not have a public variable
        //audioClip = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
