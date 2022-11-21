using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public GameObject Login_Screen;
    public GameObject Menu_Screen;
    public Button testButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = testButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
        // if the user is valud
        // if the user's password is incorrect 
        Login_Screen.SetActive(false);
        Menu_Screen.SetActive(true);
    }
}
