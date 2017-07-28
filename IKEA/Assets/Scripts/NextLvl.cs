using UnityEngine;
using System.Collections;

public class NextLvl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(0.5f * Screen.width-100, 0.65f * Screen.height, 200, 40), "Next level"))
        {
            Application.LoadLevel("IKEAroom2");
        }
    }
}
