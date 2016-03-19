using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Managerhome : MonoBehaviour {
	public static Managerhome instance;
	public Text frasetext;
	private Crucigrama Cruciactual;
	private List<string> frases=new List<string>();
	private int index;
	// Use this for initialization
	void Awake (){
		index = 0;
		if (instance == null) {
			instance = this;
		}
		if (!GameObject.Find ("Parser")) {
			GameObject go = new GameObject ();
			go.name="Parser";
			go.AddComponent<Parser> ();
		}
	}

	public void CargarCruci(int id){
		Cruciactual = Parser.instance.GetCrossword (id);
		frases.Clear ();
		for (int i = 0; i < Cruciactual.palabras.Length; i++) {
			frases.Add (Cruciactual.palabras [i].def);
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
