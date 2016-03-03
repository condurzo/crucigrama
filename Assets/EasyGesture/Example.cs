using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {

	void OnEnable () {
		EasyGesture.onSwipe += OnSwipe;

	}
	void OnDisable () {
		EasyGesture.onSwipe -= OnSwipe;

	}

	void OnSwipe(EasyGesture.Gesture type, float speed){
		switch(type){

		case EasyGesture.Gesture.SWIPE_LEFT :
			transform.Translate(Vector3.left*speed*Time.deltaTime);
			break;

		case EasyGesture.Gesture.SWIPE_RIGHT :
			transform.Translate(Vector3.right*speed*Time.deltaTime);
			break;
		}
	}

}
