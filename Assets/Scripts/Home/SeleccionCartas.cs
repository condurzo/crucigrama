using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SeleccionCartas : MonoBehaviour {

	public GameObject[] cartasLista;
	public GameObject[] cartasGrandes;
	public Text DescripcionCarta;

	public void CartaChicaNoMostrar () {
		foreach (GameObject obj in cartasLista){
			obj.active = false;
		}
	}
	public void CartaChicaMostrar () {
		foreach (GameObject obj in cartasLista){
			obj.active = true;
		}
		DescripcionCarta.text = "Descripcion de la carta.";
	}

}
