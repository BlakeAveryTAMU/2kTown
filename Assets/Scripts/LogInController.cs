using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyNavigator;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.Tilemaps;

public class LogInController : MonoBehaviour
{

    public TMP_InputField loginEmail, loginPassword, signupEmail, signupPassword, signupConfirmPassword;

    public GameObject errorPopup;
    public TMP_Text errorTitle, errorMessage;

    public void LoginUser(){

        // check if info is empty
        if (string.IsNullOrEmpty(loginEmail.text) || string.IsNullOrEmpty(loginPassword.text)){
            showErrorPopup("Error", "Missing Email or Password");
            return;
        }

        // Log in the user and display pop up if sign in successful or unsuccessful
    }

    public void SignupUser(){

        if (string.IsNullOrEmpty(signupEmail.text) || string.IsNullOrEmpty(signupConfirmPassword.text) || string.IsNullOrEmpty(signupPassword.text)){
            showErrorPopup("Error", "Missing Email or Password");
            return;
        }

        // Do sign up, then have a pop up that redirects to login
    }

    private void showErrorPopup(string title, string message){

        errorTitle.text = "" + title;
        errorMessage.text = "" + message;

        errorPopup.SetActive(true);
    }

    public void closeErrorPopup(){
        errorTitle.text = "";
        errorMessage.text = "";
        errorPopup.SetActive(false);
    }
}
