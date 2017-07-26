using UnityEngine;
using System.Collections;



public class Succes : MonoBehaviour 
{
    public AudioSource myAudio;
    public AudioClip Drop;

    // Use this for initialization
    void Start () 
    {
        DontDestroyOnLoad(transform.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("KnottenBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("SuccesScreen");
        }

        if (collision.gameObject.CompareTag("MartinBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("Fail");
        }
        if (collision.gameObject.CompareTag("LerhamnBigBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("Fail");
        }
        if (collision.gameObject.CompareTag("BillyBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("Fail");
        }



    }
}

