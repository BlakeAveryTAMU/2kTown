using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyNavigator {
    public class Navigator : MonoBehaviour
    {   
        // Go to the login screen
        public void GoToLoginScreen(){
            SceneManager.LoadSceneAsync("Log In");
        }

        // Go to sign up screen
        public void GoToSignupScreen(){
            SceneManager.LoadSceneAsync("Signup");
        }


    }

}
