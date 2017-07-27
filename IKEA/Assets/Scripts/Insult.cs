using UnityEngine;
using System.Collections;

public class Insult : MonoBehaviour {

    public AudioSource myAudio;
    public AudioClip InsultMe;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            myAudio.PlayOneShot(InsultMe);
        } 
    }
}
