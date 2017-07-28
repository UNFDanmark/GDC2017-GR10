using UnityEngine;
using System.Collections;

public class TutTimer : MonoBehaviour {

    public float Timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        Timer = Timer - Time.deltaTime;
        if(Timer <= 0) 
        {
            Application.LoadLevel("IKEAroom1");
        }
    }
}
