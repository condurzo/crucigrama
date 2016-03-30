using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Prime31;


public class TwitterManager : MonoBehaviour
{
#if UNITY_IPHONE
	// Fired after a successful login attempt was made
	public static event Action loginSucceededEvent;
	
	// Fired when an error occurs while logging in
	public static event Action<string> loginFailedEvent;
	
	// Fired when a custom request completes. The object will be either an IList or an IDictionary
	public static event Action<object> requestDidFinishEvent;
	
	// Fired when a custom request fails
	public static event Action<string> requestDidFailEvent;
	
	// Fired when the tweet sheet completes. True indicates success and false cancel/failure.
	public static event Action<bool> tweetSheetCompletedEvent;
	
	

	static TwitterManager()
	{
		AbstractManager.initialize( typeof( TwitterManager ) );
	}
	
	
	public void twitterLoginSucceeded( string empty )
	{
		if( loginSucceededEvent != null )
			loginSucceededEvent();
	}
	
	
	public void twitterLoginDidFail( string error )
	{
		if( loginFailedEvent != null )
			loginFailedEvent( error );
	}

	
	public void twitterRequestDidFinish( string results )
	{
		if( requestDidFinishEvent != null )
			requestDidFinishEvent( Json.jsonDecode( results, true ) );
	}
	
	
	public void twitterRequestDidFail( string error )
	{
		if( requestDidFailEvent != null )
			requestDidFailEvent( error );
	}
	
	
	public void tweetSheetCompleted( string oneOrZero )
	{
		if( tweetSheetCompletedEvent != null )
			tweetSheetCompletedEvent( oneOrZero == "1" );
	}

#endif
}
