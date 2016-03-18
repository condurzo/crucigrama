using UnityEngine;
using System.Collections;

public class ActivarFondoCrucigrama : MonoBehaviour {

	public GameObject Fondo;


	public void Update() {
		if(FondoCrucigrama.Activo){
			Debug.Log("LALALALA");
			Fondo.SetActive(true);
			FondoCrucigrama.Activo=false;
		}
	}
}
