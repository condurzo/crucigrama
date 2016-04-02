using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class Managerhome : MonoBehaviour {
	public static Managerhome instance;
	public Text frasetext;
	public Text palabrastext;
	private Crucigrama Cruciactual;
	private List<string> frases=new List<string>();
	private int index;
	public GameObject crucigramajuego;
	public GameObject parse;
	// Use this for initialization
	void Awake (){
		index = 0;
		if (instance == null) {
			instance = this;
		}
		if (!GameObject.Find ("Parser")) {
			GameObject go = Instantiate(parse)as GameObject;
			go.name="Parser";
		}
	}

	public void CargarCruci(int id){
		Debug.Log ("cargo cruci");
		Cruciactual = Parser.instance.GetCrossword (id);
		frases.Clear ();
		for (int i = 0; i < Cruciactual.palabras.Length; i++) {
			frases.Add (Cruciactual.palabras [i].def);
		}
		index = 0;
		if(frases.Count>0){
		if(frases.Count>=index){
			Debug.Log(frases.Count);
			Debug.Log(index);
			frasetext.text = frases [index];
			string pal = "Palabras: ";
			for (int i = 0; i < Cruciactual.palabras.Length; i++) {
				pal += ";" + Cruciactual.palabras [i].nom;
			}
			palabrastext.text = pal;
		}
		}else{
			palabrastext.text="Sin Palabras";
		}
	}

	public void Siguiente(){
		index++;
		if (index > frases.Count) {
			index = 0;
		}
		frasetext.text = frases [index];
	}

	public void Anterior(){
		index--;
		if (index < 0) {
			index = frases.Count;
		}
		frasetext.text = frases [index];
	}
}
