using UnityEngine;
using System.Collections;

public class EnviandoTemp : MonoBehaviour {

	public GameObject CartaShow;

	void Start () {
		Invoke ("Cerrar", 3);
	}
	
	void Cerrar () {
		CartaShow.SetActive (true);
		this.gameObject.SetActive (false);
	}
}
