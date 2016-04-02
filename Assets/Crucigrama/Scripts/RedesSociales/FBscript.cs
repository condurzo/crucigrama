using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using Facebook.Unity;

public class FBscript : MonoBehaviour{

    public GameObject DialogUsername;
    public GameObject DialogId;
    public string UsserFB;
    public string idFB;
    public string AppLinkURL { get; set; }


    void Start(){
        FB.Init(SetInit, OnHideUnity);
    }

    void SetInit(){
        if (FB.IsLoggedIn){
            Debug.Log("FB is logged in");
        }else {
            Debug.Log("FB is not logged in");
        }
        DealWithFBMenus(FB.IsLoggedIn);
    }

    void OnHideUnity(bool isGameShown){
        if (!isGameShown){
            Time.timeScale = 0;
        }else {
            Time.timeScale = 1;
        }
    }

    public void FBlogin(){

        List<string> permissions = new List<string>();
        permissions.Add("public_profile");

        FB.LogInWithReadPermissions(permissions, AuthCallBack);
        
    }

    public void FBLogout(){
        CallFBLogout();
    }

    private void CallFBLogout(){
        FB.LogOut();
        Debug.Log("Cerre Sesion");
    }

    void AuthCallBack(IResult result){

        if (result.Error != null){
            Debug.Log(result.Error);
        }else{
            if (FB.IsLoggedIn){
                Debug.Log("FB is logged in");
            }else{
                Debug.Log("FB is not logged in");
            }
            DealWithFBMenus(FB.IsLoggedIn);
        }
    }

    void DealWithFBMenus(bool isLoggedIn){

        if (isLoggedIn){
            FB.API("/me?fields=id,name", HttpMethod.GET, DisplayUsername);
            //FB.API("/me/picture?type=square&height=128&width=128", HttpMethod.GET, DisplayProfilePic);
        }else{
          
        }
    }
    
    public void DisplayUsername(IResult result){
        Text UserName = DialogUsername.GetComponent<Text>();
        Text UserId = DialogId.GetComponent<Text>();
        if (result.Error == null){
            UserName.text = "" + result.ResultDictionary["name"];
            UserId.text = "" + result.ResultDictionary["id"];
            idFB = UserId.text;
            Parser.instance.RegistrarUsuario(idFB, UserName.text, "");
        }
        else {
            Debug.Log(result.Error);
        }
    }

    //void DisplayProfilePic(IGraphResult result){
    //    if (result.Texture != null){
    //        Image ProfilePic = DialogProfilePic.GetComponent<Image>();
    //        ProfilePic.sprite = Sprite.Create(result.Texture, new Rect(0, 0, 128, 128), new Vector2());
    //    }
    //}

    public void Share(){
        FB.FeedShare(
            string.Empty,
            new Uri(AppLinkURL),
            "Hello this is the title",
            "This is the caption",
            "Check out this game",
            new Uri("https://i.ytimg.com/vi/NtgtMQwr3Ko/maxresdefault.jpg"),
            string.Empty,
            ShareCallback
        );
    }

    void ShareCallback(IResult result){
        if (result.Cancelled){
            Debug.Log("Share Cancelled");
        }else if (!string.IsNullOrEmpty(result.Error)){
            Debug.Log("Error on share!");
        }else if (!string.IsNullOrEmpty(result.RawResult)){
            Debug.Log("Success on share");
        }
    }

    void DealWithAppLink(IAppLinkResult result){
        /* 
			result.Url can return null if your app is not fully published and does not have an app page. 
			The else statement will provide a fallback incase this happens.
			When you call FB.FeedShare or FB.Mobile.AppInvite on iOS and the url string is null it will crash your app.
		*/
        if (!String.IsNullOrEmpty(result.Url)){
            AppLinkURL = "" + result.Url + "";
            Debug.Log(AppLinkURL);
        }else{
            AppLinkURL = "http://google.com";
        }
    }




	//// SHARES FACEBOOK
	#if UNITY_ANDROID
	public void ShareHome(){
		FB.FeedShare(
			string.Empty,
			new Uri(AppLinkURL),
			"Hello this is the title",
			"This is the caption",
			"Check out this game",
			new Uri("https://i.ytimg.com/vi/NtgtMQwr3Ko/maxresdefault.jpg"),
			string.Empty,
			ShareCallback
		);
	}
	#endif

}