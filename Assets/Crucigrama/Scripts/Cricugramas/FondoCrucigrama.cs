using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FondoCrucigrama : MonoBehaviour {

	public Button boton;
	public GameObject ActivarFondo;
	public static bool Activo;

	void Start(){
		boton = gameObject.GetComponent<Button>();
		boton.onClick.AddListener(delegate() { Prender(); });
	}

	void Prender(){
		Activo = true;
	}

}
