using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gridcell : MonoBehaviour {
	public Text Character;
	public string texto;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Actualizar () {
		Character.text=texto;
	}
}
