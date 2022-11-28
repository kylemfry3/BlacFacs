using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfoManager : MonoBehaviour
{
    private string id, pw;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setID(string i)
    {
        id = i;
    }
    public void setPW(string p)
    {
        pw = p;
    }
    public string getID()
    {
        return id;
    }
    public string getPW()
    {
        return pw;
    }
}
