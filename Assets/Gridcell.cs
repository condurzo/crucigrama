using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gridcell : MonoBehaviour {
	public Text Character;
	public string texto;
	public bool prendido;
	// Use this for initialization
	void Start () {
		prendido=true;
	}
	
	// Update is called once per frame
	public void Actualizar () {
		Character.text=texto;
		if(!prendido){
			this.gameObject.SetActive(false);
		}
	}
}
