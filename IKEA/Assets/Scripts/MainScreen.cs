using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainScreen : MonoBehaviour {

    public Button StartButton;
    public Button LevelButton;
    public Button CreditsButton;

    // Use this for initialization
    void Start () {
        
        Button btn = StartButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button btn1 = LevelButton.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);

        Button btn2 = CreditsButton.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
    }
	
	// Update is called once per frame
	void TaskOnClick() {
        Application.LoadLevel("IKEAroom1");
    }
    void TaskOnClick1()
    {
        Application.LoadLevel("LevelSelect");
    }
    void TaskOnClick2()
    {
        Application.LoadLevel("IKEAroom1");
    }
}
