using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CrucigramaShower : MonoBehaviour {
	public Button boton;
	public Image imagen;
	public Text Nombre;
	public Text palabras;
	public Text estado;
	public int id;

	void Awake(){
		boton.onClick.AddListener(delegate() { Prender(); });
	}

	public void Resolver(){
		Managerhome.instance.CargarCruci (id);
	}

	public void Prender(){
		GameObject go = Managerhome.instance.crucigramajuego;
		go.SetActive (true);
	}
}
