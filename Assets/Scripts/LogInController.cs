using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyNavigator;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.Tilemaps;
using UnityEngine.Networking;

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

    private IEnumerator SendSignupRequest(string email, string password, int team_id)
    {
        var requestData = new
        {
            email = email,
            password = password,
            team_id = team_id
        };

        // Convert to JSON
        string json = JsonUtility.ToJson(requestData);

        // Create a UnityWebRequest for posting the JSON data
        using (UnityWebRequest www = UnityWebRequest.Post("https://twoktownserver.onrender.com/api/add_user", json))
        {
            www.SetRequestHeader("Content-Type", "application/json");

            // Send the request and wait for a response
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                showErrorPopup("Error", www.error);
            }
            else
            {
                // Handle the response data (www.downloadHandler.text)
                Debug.Log("Signup response: " + www.downloadHandler.text);
                // Add logic to handle successful signup
            }
        }
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
