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
	public string UrlCarta;
	public String url; 
	public GameObject LoginPopup;


    void Start(){
        FB.Init(SetInit, OnHideUnity);
    }

	public void ExitApp(){
		if((Application.platform==RuntimePlatform.WindowsEditor)||(Application.platform==RuntimePlatform.OSXEditor)){
			LoginPopup.SetActive(false);
			Debug.Log("CIERRO LOGIN");
		}else{
			Application.Quit ();
		}
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
		if (PlayerPrefs.GetInt ("Registrado") == 1) {
			PlayerPrefs.SetString ("IdFacebook", "a");
			PlayerPrefs.SetString ("IdPlayer", "a");
			PlayerPrefs.SetString ("c1","a");
			PlayerPrefs.SetString ("c2","a");
			PlayerPrefs.SetString ("c3","a");
			PlayerPrefs.SetString ("c4","a");
			PlayerPrefs.SetInt ("Registrado", 0);
			PlayerPrefs.SetInt ("SetearCosas", 0);
			PlayerPrefs.SetInt("BajoCartas", 0);
			Application.LoadLevel ("PreSplash");
			Debug.Log ("Cerre Sesion");
		}
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
			PlayerPrefs.SetString ("IdFacebook", idFB);
			Debug.Log ("IDFACE: " + idFB);
			Parser.instance.ObtenerIDCorutine ();
			Parser.instance.RegistrarUsuario (idFB, UserName.text, mail);
			string idTemp = PlayerPrefs.GetString ("IdPlayer");
			Parser.instance.ObtenerProgreso (idTemp);
			BajarCartar ();
        }
        else {
            Debug.Log(result.Error);
        }
    }

	public void BajarCartar(){
		string idTemp = PlayerPrefs.GetString ("IdPlayer");
		Debug.Log("IDTEMP: "+idTemp);
		Parser.instance.ObtenerEstadoJugador(idTemp);
		Debug.Log("C1 :"+PlayerPrefs.GetString ("c1"));
		Debug.Log("C2 :"+PlayerPrefs.GetString ("c2"));
		Debug.Log("C3 :"+PlayerPrefs.GetString ("c3"));
		Debug.Log("C4 :"+PlayerPrefs.GetString ("c4"));
		Application.LoadLevel ("Home");
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

	void Update(){
		if ((PlayerPrefs.GetInt ("Registrado") == 1)) {
			if ((PlayerPrefs.GetString ("c4") == "a")||(PlayerPrefs.GetString ("c4") == "")||(PlayerPrefs.GetString ("c4") == "0")) {
				if (PlayerPrefs.GetInt("BajoCartas") == 0) {
					BajarCartar ();
					PlayerPrefs.SetInt("BajoCartas", 1);
				}
			}
		} else {
			LoginPopup.SetActive (true);
		}


//		Debug.Log(PlayerPrefs.GetString ("IdFacebook"));
//		Debug.Log(PlayerPrefs.GetString ("IdPlayer"));
//		Debug.Log("C1 :"+PlayerPrefs.GetString ("c1"));
//		Debug.Log("C2 :"+PlayerPrefs.GetString ("c2"));
//		Debug.Log("C3 :"+PlayerPrefs.GetString ("c3"));
//		Debug.Log("C4 :"+PlayerPrefs.GetString ("c4"));

//

		int CartasShares;
		CartasShares = PlayerPrefs.GetInt("ShareCarta");
		switch (CartasShares) {
		case 01:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/01_El_Mago.png";
			break;
		case 02:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/02_La_Sacerdotisa.png";
			break;
		case 03:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/03_La_Emperatriz.png";
			break;
		case 04:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/04_El_Emperador.png";
			break;
		case 05:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/05_El_Sacerdote.png";
			break;
		case 06:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/06_Los%20Enamorados.png";
			break;
		case 07:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/07_El_Carro.png";
			break;
		case 08:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/08_La_Justicia.png";
			break;
		case 09:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/09_El_Ermita%c3%b1o.png";
			break;
		case 10:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/10_La_Rueda_de_la_Fortuna.png";
			break;
		case 11:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/11_La_Fuerza.png";
			break;
		case 12:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/12_El_Ahorcado.png";
			break;
		case 13:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/13_La_Muerte.png";
			break;
		case 14:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/14_La_Templanza.png";
			break;
		case 15:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/15_El_Diablo.png";
			break;
		case 16:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/16_La_Torre.png";
			break;
		case 17:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/17_La_Estrella.png";
			break;
		case 18:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/18_La_Luna.png";
			break;
		case 19:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/19_El_Sol.png";
			break;
		case 20:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/20_El_Juicio.png";
			break;
		case 21:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/21_El_Mundo.png";
			break;
		case 22:
			UrlCarta = "http://www.malditosnerds.com/crucigramas/uploads/shared/22_El_Loco.png";
			break;
		}
	}

	public void CompartirHome(){
		FB.FeedShare(
			string.Empty,
			new Uri("https://play.google.com/store/apps/details?id=com.malditosnerds.crucigrama"),//URL App
			"Estoy jugando con la App de Malditos Nerds.",//Title
			"",//SubTitle
			"",//Descripcion
			new Uri("http://www.malditosnerds.com/crucigramas/uploads/shared/home.jpg"),//Imagen
			string.Empty,
			ShareCallback);
	}

	public void CartaShare(){//http://www.malditosnerds.com/crucigramas/uploads/shared/
		FB.FeedShare(
			string.Empty,
			new Uri("https://play.google.com/store/apps/details?id=com.malditosnerds.crucigrama"),//URL App
			"Mi nueva carta de la coleccion en la App de Malditos Nerds.",//Title
			"",//SubTitle
			"",//Descripcion
			new Uri(UrlCarta),//Imagen
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