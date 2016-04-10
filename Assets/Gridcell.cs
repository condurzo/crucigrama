using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gridcell : MonoBehaviour {
	public Text Character;
	public Button btn;
	public  Image contenedor;
	public  Image borde;
	public string texto;
	public int indexword;
	public bool prendido;
	public bool duplicado;

	// Use this for initialization
	void Awake () {
		Reset();
	}
	
	public void Actualizar () {
		bool estado=true;
		Character.text=texto;
		if(!prendido){
			estado=false;
		}else{
			estado=true;
		}
		btn.enabled=estado;
		Character.enabled=estado;
		contenedor.enabled=estado;
		borde.enabled=estado;
		if(prendido){
			btn.enabled=!duplicado;
		}

		if(contenedor.color==Color.black){
			Character.color=Color.white;
		}else{
			Character.color=Color.black;
		}
	}

	public void Reset(){
		duplicado=false;
		prendido=true;
		texto=" ";
	}

	public void Accion(){
		Debug.Log(indexword);
		Managerhome.palabraescribiendo=indexword;
		Managerhome.instance.cambiarfrase();
	}
}
