using UnityEngine;
using System.Collections;

public class HomeSelector : MonoBehaviour {

	public GameObject SeccionCrucigramas;
	public GameObject SeccionCartas;

	void SelectCrucigramas () {
		SeccionCrucigramas.SetActive(true);
		SeccionCartas.SetActive(false);
	}
	
	void SelectCartas () {
		SeccionCrucigramas.SetActive(false);
		SeccionCartas.SetActive(true);
	}




}
