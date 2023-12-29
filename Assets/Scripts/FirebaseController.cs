using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyNavigator;
using UnityEngine.UI;
using System;
using TMPro;

public class FirebaseController : MonoBehaviour
{

    public TMP_InputField loginEmail, loginPassword, signupEmail, signupPassword, signupConfirmPassword;

    public void LoginUser(){

        // check if info is empty
        if (string.IsNullOrEmpty(loginEmail.text) || string.IsNullOrEmpty(loginPassword.text)){
            Console.WriteLine("Empty Username or Password");
            return;
        }

        // Log in the user
    }

    public void SignupUser(){

        if (string.IsNullOrEmpty(signupEmail.text) || string.IsNullOrEmpty(signupConfirmPassword.text) || string.IsNullOrEmpty(signupPassword.text)){
            Console.WriteLine("Empty Username or Password");
            return;
        }

        // Do sign up
    }
}
