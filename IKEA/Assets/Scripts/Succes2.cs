using UnityEngine;
using System.Collections;

public class Succes2 : MonoBehaviour {

    public AudioSource myAudio;
    public AudioClip Drop;
    public bool HemnesIsOn = false;
    public bool KivikIsOn = false;
    public bool NorrarydIsOn = false;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("KnottenBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("Fail");
        }

        if (collision.gameObject.CompareTag("MartinBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("Fail");
        }
        if (collision.gameObject.CompareTag("LerhamnBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("Fail");
        }
        if (collision.gameObject.CompareTag("BillyBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("Fail");
        }
        if (collision.gameObject.CompareTag("AvsiktligBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("Fail");
        }


        if (collision.gameObject.CompareTag("HemnesBoks"))
        {
            myAudio.PlayOneShot(Drop);
            HemnesIsOn = true;
        }
        if (collision.gameObject.CompareTag("KivikBoks"))
        {
            myAudio.PlayOneShot(Drop);
            KivikIsOn = true;
        }

        if (collision.gameObject.CompareTag("NorrarydBoks"))
        {
            myAudio.PlayOneShot(Drop);
            NorrarydIsOn = true;
        }
        if (HemnesIsOn == true && KivikIsOn == true && NorrarydIsOn == true) 
        {
            Application.LoadLevel("SuccesScreen");
        }


    }
}
