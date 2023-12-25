using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToSignup : MonoBehaviour
{
    public void SwitchToSignupScene(){

        System.Console.WriteLine("Signup button pressed");
        SceneManager.LoadSceneAsync("Signup");
    
    }
}
