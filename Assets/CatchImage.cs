using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchImage : MonoBehaviour
{
    private Rigidbody c; // object colliding

    private AudioSource audio; // Gets both audio components
    public AudioClip audioWin; // audio for correct image
    public AudioClip audioLose; // audio for incorrect image

    // Start is called before the first frame update
    void Start()
    {
        c = transform.GetComponent<Rigidbody>();

        audio = transform.GetComponent<AudioSource>();
        //audioWin = transform.GetComponent<AudioSource>(); // the audio for if the correct image is chosen
        //audioLose = transform.GetComponent<AudioSource>(); // the audio for if the incorrect image is chosen

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        // check if the GameObject has a certain tag
        if (c.tag == "Correct")
        {
            audio.clip = audioWin;
            audio.PlayOneShot(audio.clip); // correct audio

            // ADD CODE HERE TO UPDATE SCORE

        }

        if (c.tag == "Incorrect")
        {
            audio.clip = audioLose;
            audio.PlayOneShot(audio.clip); // correct audio

            // ADD CODE HERE TO UPDATE SCORE

        }
        //other.transform.GetComponent<Rigidbody>().position = new Vector3(0, 10, -15);
        //other.AddForce(Vector3.forward);


        //audio.PlayOneShot(audio.clip); // 

        //other.GameObject.transform.position=Vector3(-3.5,2,-12.5)

        //        // other.transform.position=Vector3(-3.5,2,-12.5);

    }
}
