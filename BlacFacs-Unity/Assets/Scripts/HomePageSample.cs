using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePageSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject uim = GameObject.Find("UserInfoManager");
        //access to the script to set user id and pw.
        UserInfoManager user_manager = uim.GetComponent<UserInfoManager>();
        string id = user_manager.getID();
        string pw = user_manager.getPW();

        //check whether we can access to user id and pw data.
        Debug.Log(id + pw);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
