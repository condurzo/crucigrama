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
			string mail = idFB + "F";
			Parser.instance.RegistrarUsuario (idFB, UserName.text, mail);
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

	public void CompartirHome(){
		FB.FeedShare(
			string.Empty,
			new Uri("https://play.google.com/store/apps/details?id=com.malditosnerds.crucigrama"),//URL App
			"Estoy jugando con la App de Malditos Nerds.",//Title
			"",//SubTitle
			"",//Descripcion
			new Uri("https://k40.kn3.net/taringa/2/3/3/1/7/5/8/alessa_gillespie/485.jpg"),//Imagen
			string.Empty,
			ShareCallback);
	}

	public void Carta00(){//http://www.malditosnerds.com/crucigramas/uploads/shared/
		FB.FeedShare(
			string.Empty,
			new Uri("https://play.google.com/store/apps/details?id=com.malditosnerds.crucigrama"),//URL App
			"Mi nueva carta de la coleccion en la App de Malditos Nerds.",//Title
			"",//SubTitle
			"",//Descripcion
			new Uri("http://www.malditosnerds.com/crucigramas/uploads/shared/Carta_01.png"),//Imagen
			string.Empty,
			ShareCallback);
	}

	public void CompartirCartasGanadas(){
		int RandomCartas;
		RandomCartas = UnityEngine.Random.Range(1, 4);
		switch (RandomCartas) {
		case 1:
			FB.FeedShare(
				string.Empty,
				new Uri("https://play.google.com/store/apps/details?id=com.malditosnerds.crucigrama"),//URL App
				"El momento mágico en la App de Malditos Nerds.",//Title
				"",//SubTitle
				"",//Descripcion
				new Uri("http://www.malditosnerds.com/crucigramas/uploads/shared/Cartas_Ganadas_Redes_Sociales_01.png"),//Imagen
				string.Empty,
				ShareCallback);
			break;
		case 2:
			FB.FeedShare(
				string.Empty,
				new Uri("https://play.google.com/store/apps/details?id=com.malditosnerds.crucigrama"),//URL App
				"El momento mágico en la App de Malditos Nerds.",//Title
				"",//SubTitle
				"",//Descripcion
				new Uri("http://www.malditosnerds.com/crucigramas/uploads/shared/Cartas_Ganadas_Redes_Sociales_02.png"),//Imagen
				string.Empty,
				ShareCallback);
			break;
		case 3:
			FB.FeedShare(
				string.Empty,
				new Uri("https://play.google.com/store/apps/details?id=com.malditosnerds.crucigrama"),//URL App
				"El momento mágico en la App de Malditos Nerds.",//Title
				"",//SubTitle
				"",//Descripcion
				new Uri("http://www.malditosnerds.com/crucigramas/uploads/shared/Cartas_Ganadas_Redes_Sociales_03.png"),//Imagen
				string.Empty,
				ShareCallback);
			break;
		}
	}

	#endif

}