using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gridcell : MonoBehaviour {
	public Text Character;
	private Button btn;
	private Image imagen;
	public string texto;
	public bool prendido;

	// Use this for initialization
	void Awake () {
		prendido=true;
		btn=this.gameObject.GetComponent<Button>();
		imagen=this.gameObject.GetComponent<Image>();
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
		imagen.enabled=estado;
	}
}
