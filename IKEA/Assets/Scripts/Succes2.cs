using UnityEngine;
using System.Collections;

public class Succes2 : MonoBehaviour {

    public AudioSource myAudio;
    public AudioClip Drop;
    public bool HemnesIsOn = false;
    public bool KivikIsOn = false;
    public bool NorrarydIsOn = false;
    public GameObject KivikPic;
    public GameObject HemnesPic;
    public GameObject NorrarydPic;

    // Use this for initialization
    void Start()
    {

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
            Application.LoadLevel("FailRoom2");
        }

        if (collision.gameObject.CompareTag("MartinBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("FailRoom2");
        }
        if (collision.gameObject.CompareTag("LerhamnBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("FailRoom2");
        }
        if (collision.gameObject.CompareTag("BillyBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("FailRoom2");
        }
        if (collision.gameObject.CompareTag("AvsiktligBoks"))
        {
            myAudio.PlayOneShot(Drop);
            Application.LoadLevel("FailRoom2");
        }


        if (collision.gameObject.CompareTag("HemnesBoks"))
        {
            myAudio.PlayOneShot(Drop);
            HemnesIsOn = true;
            Destroy(HemnesPic.gameObject);
        }
        if (collision.gameObject.CompareTag("KivikBoks"))
        {
            myAudio.PlayOneShot(Drop);
            KivikIsOn = true;
            Destroy(KivikPic.gameObject);
        }

        if (collision.gameObject.CompareTag("NorrarydBoks"))
        {
            myAudio.PlayOneShot(Drop);
            NorrarydIsOn = true;
            Destroy(NorrarydPic.gameObject);
        }
        if (HemnesIsOn == true && KivikIsOn == true && NorrarydIsOn == true) 
        {
            Application.LoadLevel("MainMenu");
        }
    }

}
