using UnityEngine;
using System.Collections;

public class FailRoom1Re : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(815, 650, 200, 40), "Try again?"))
        {
            Application.LoadLevel("IKEAroom1");
        }
    }
}
