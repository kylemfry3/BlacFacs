using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SingInButtonClicked : MonoBehaviour
{
    public GameObject id_input;
    public GameObject pw_input;
    public Toggle rememberMe;
    private string id, pw;
    public GameObject errmsg;
    // Start is called before the first frame update
    void Start()
    {
        
        //pw = pw.GetComponent<InputField>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Signin()
    {
        id = id_input.GetComponent<TMP_InputField>().text;
        pw = pw_input.GetComponent<TMP_InputField>().text;
        Debug.Log("user id:"+id +", user pw:"+ pw + ",remember me?"+ rememberMe.isOn);
        if (IsInDB(id, pw))
        {
            //if remember me check box is checked, remember this user. From the next time this user executes our apps, we skip the Welcome page, but start from Home Page. 
            if (rememberMe.isOn)
            {

                //remember this user data in local device or somewhere else.
            }
            if (MatchPW(id, pw)){
                //Login success, move to HomePage with user information
                GameObject uim = GameObject.Find("UserInfoManager");
                //access to the script to set user id and pw.
                UserInfoManager user_manager = uim.GetComponent<UserInfoManager>();
                user_manager.setID(id);
                user_manager.setPW(pw);
                SceneManager.LoadScene("HomePage");
            }
            else
            {
                ErrorMSG(1);
            }

           

        }
        else
        {
            //log in failed your id does not exist.
            ErrorMSG(0);
        }
    }
    //Check if the user has signed up or id and pw are mateched.
    //Since we don't have the DB yet, I leave it to return true for this time.
    private bool IsInDB(string id, string pw)
    {
        //using id, find user id first in our DB. ex) SELECT * FROM users WHERE id = id
        //if the length of the above query is one, continue. else, return False (the user hasn't signed up)
        Highlight(id_input);
        return false;
    }

    //using pw, check if the pw is matched with the id. ex) SELECT * FROM users WEHRE id = id AND pw = pw
    //if the length of the above query is one, return True, else False.
    private bool MatchPW(string id, string pw)
    {
        Highlight(pw_input);
        return false;
    }
    private void Highlight(GameObject target)
    {
        if (target.GetComponent<Outline>() == null)
        {
            target.AddComponent<Outline>();
        }
        Outline outline = target.GetComponent<Outline>();
        outline.effectColor = Color.red;
    }

    private void ErrorMSG(int type)
    {
        string desc = (type == 0) ? "Your ID does not exist." : "Your password is not correct.";
        errmsg.GetComponent<TextMeshProUGUI>().text = "Login Failed!\n" + desc;
        
    }
}
