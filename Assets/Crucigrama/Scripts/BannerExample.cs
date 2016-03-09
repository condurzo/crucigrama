using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class BannerExample : MonoBehaviour {

	//Pagina de google ads: https://developers.google.com/admob/android/games#importing_anysdk_into_your_game

	private void RequestBanner()
	{
		#if UNITY_ANDROID
		string adUnitId = "pub-2108399690795188";
		#elif UNITY_IPHONE
		string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		// Create a 320x50 banner at the top of the screen.
		BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
		bannerView.LoadAd(request);
		}
}
