using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainScreen : MonoBehaviour {

    public Button StartButton;
    public Button LevelButton;


    // Use this for initialization
    void Start () {
        
        Button btn = StartButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button btn1 = LevelButton.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);

    }
	
	// Update is called once per frame
	void TaskOnClick() {
        Application.LoadLevel("Tut");
    }
    void TaskOnClick1()
    {
        Application.LoadLevel("LevelSelect");
    }

}
