using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using Prime31;

public class TwitterScript : Prime31.MonoBehaviourGUI{

#if UNITY_IPHONE
	public bool canUseTweetSheet = false; // requires iOS 5 and a Twitter account setup in Settings.app

	void Start(){
		canUseTweetSheet = TwitterBinding.isTweetSheetSupported() && TwitterBinding.canUserTweet();
        InitializeTwitter();
	}
    // common event handler used for all graph requests that logs the data to the console
	void completionHandler( string error, object result ){
		if( error != null )
			Debug.LogError( error );
		else
			Prime31.Utils.logObject( result );
	}

	public void InitializeTwitter(){
		TwitterBinding.init( "INSERT_YOUR_INFO_HERE", "INSERT_YOUR_INFO_HERE" );
		TwitterBinding.init( "YpmCpu7oRkGQuQ2rXcqlqNcaw", "kVX9OJgNC6BP5DsiebFfkp0PdMx0ZyWEUr6X2LVEDw8lBd9l1k" );
	}


	public void LoginTwitter(){
		TwitterBinding.showOauthLoginDialog();
	}

	public void LogoutTwitter(){
		TwitterBinding.logout();
	}

	public void IsLoggedInTwitter(){
		bool isLoggedIn = TwitterBinding.isLoggedIn();
		Debug.Log( "Twitter is logged in: " + isLoggedIn );
	}

	public void UsernameTwitter(){
		string username = TwitterBinding.loggedInUsername();
		Debug.Log( "Twitter username: " + username );
	}


	public void PostTwitter(){
		TwitterBinding.postStatusUpdate( "POSTEANDO DESDE UNITY: " + Time.deltaTime );
	}

	public void PostImage(){
		//var pathToImage = Application.persistentDataPath + "/" + FacebookGUIManager.screenshotFilename;
		//TwitterBinding.postStatusUpdate( "FOTO TEST: " + Time.deltaTime, pathToImage );
	}
	
#endif

#if UNITY_ANDROID

    public TwitterAndroidEventListener _UserName;
    public string username;
    public string UsserTwitter;

    void Start() {
        InitializeTwitter();
        Debug.Log("Inicio Twitter");
    }

    public void InitializeTwitter(){
        // Replace these with your own credentials!!!
        TwitterAndroid.init("YpmCpu7oRkGQuQ2rXcqlqNcaw", "kVX9OJgNC6BP5DsiebFfkp0PdMx0ZyWEUr6X2LVEDw8lBd9l1k");
        //TwitterAndroid.init( "INSERT_YOUR_INFO_HERE", "INSERT_YOUR_INFO_HERE" );

    }

    public void LoginTwitter(){
        TwitterAndroid.showLoginDialog();
        _UserName.loginDidSucceedEvent(username);
		Parser.instance.RegistrarUsuario("1234123", username, "");
    }



    public void IsLoggedInTwitter(){
        var isLoggedIn = TwitterAndroid.isLoggedIn();
        Debug.Log("Is logged in?: " + isLoggedIn);
    }
    
    public void LogoutTwitter(){
        TwitterAndroid.logout();
    }

    public void UsernameTwitter(){
     
    }

    public void PostTwitter(){
        TwitterAndroid.postUpdate("Posteando" + Time.time.ToString());
    }

    public void PostImage(){
        //var pathToImage = Application.persistentDataPath + "/" + "Assets/Resources/Textures/carlos.jpg";
        //var bytes = System.IO.File.ReadAllBytes(pathToImage);
        //TwitterAndroid.postUpdateWithImage( "test update from Unity!", bytes );
    }

#endif

}
