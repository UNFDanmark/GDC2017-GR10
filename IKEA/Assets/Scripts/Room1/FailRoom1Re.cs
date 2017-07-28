using UnityEngine;
using System.Collections;

public class FailRoom1Re : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(0.5f * Screen.width - 100, 0.65f * Screen.height, 200, 40), "Try again?"))
        {
            Application.LoadLevel("IKEAroom1");
        }
    }
}
