using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*
=============================
File managed by backend team:
- Kyle Fry
- Joe Wilmot
- Sud Srinivasan
=============================
This script will gather the login credentials from the login screen and pass them to the login database.
After being returned a status of the user's credentials in the database (either 0 or 1 or something else to signify success/failure), the respective 
screen will be displayed to the user.
*/

public class ValidateCredentials : MonoBehaviour {
    // the inputs
    public TMP_InputField username;
    public TMP_InputField password;
    public Button submitButton;

    // error screen objects
    public GameObject userNF_e;
    public GameObject wrongUN_P_e;

    // screen objects
    public GameObject loginScreen;
    public GameObject homeScreen;

    // database connection stuff
    // these variables widely depend on what the client says about backend implementation
    // hopefully the client will give us APIs for the plugins they use so we can interface with their stuff
    // otherwise we need to make everything from scratch (using a MySQL server Kyle can set up)

    // Set up a listener on the "Submit" button
    void Start() {
        Button btn = submitButton.GetComponent<Button>();
        btn.onClick.AddListener(passCredentials);
    }

    // The actual "contact-the-database" stuff
    void passCredentials() {
        /*
        int login_status = ... (backend function here. Pass in the user and passwod fields. Again it'll depend on what client says)
        if (login_status == 1) {
            homeScreen.SetActive(true);
            loginScreen.SetActive(false);
        } else if (login_status == 2) {
            // assuming '2' means one of two inputs was found in the database
            wrongUN_P_e.SetActive(true);
        } else {
            // assuming any other returned value means no values found in database
            userNF_e.SetActive(true);
        }*/
    }
}
