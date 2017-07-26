using UnityEngine;
using System.Collections;

public class IKEAroom2Load : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void OnGUI() 
    {
        if(GUI.Button(new Rect (815, 650, 200, 40), "Next level")) 
        {
            Application.LoadLevel("IKEAroom2");
        }
    }
}
