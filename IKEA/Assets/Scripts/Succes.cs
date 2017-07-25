using UnityEngine;
using System.Collections;



public class Succes : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("KnottenBoks"))
        {
            Application.LoadLevel("SuccesScreen");
        }

        if (collision.gameObject.CompareTag("BigBoks"))
        {
            Application.LoadLevel("Fail");
        }



    }
}

