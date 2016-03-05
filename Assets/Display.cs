using UnityEngine;
using System.Collections;

public class Display : MonoBehaviour {
	public GameObject[] Screens;
	void Start () {
		foreach (GameObject go in Screens) {
			go.SetActive (false);
		}
		Screens[0].SetActive (true);
	}
	
	public void CambiarScreen (int num) {
		foreach (GameObject go in Screens) {
			go.SetActive (false);
		}
		Screens[num].SetActive (true);
	}
}
