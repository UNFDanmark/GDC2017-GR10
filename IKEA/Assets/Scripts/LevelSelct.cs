using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelSelct : MonoBehaviour {

    public Button Lvl1Button;
    public Button Lvl2Button;


    // Use this for initialization
    void Start()
    {

        Button btn = Lvl1Button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button btn1 = Lvl2Button.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Application.LoadLevel("IKEAroom1");
    }
    void TaskOnClick1()
    {
        Application.LoadLevel("IKEAroom2");
    }

}
