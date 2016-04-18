using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ranking : MonoBehaviour {
	public static Ranking instance;

	public Text nomrank1;
	public Text nomrank2;
	public Text nomrank3;
	public Text nomrank4;
	public Text nomrank5;

	public Text posrank1;
	public Text posrank2;
	public Text posrank3;
	public Text posrank4;
	public Text posrank5;

	// Use this for initialization
	void Awake () {
		if(instance==null){
			instance=this;
		}
		nomrank1.text=Parser.instance.jugadoresranking[0].nombre;
		nomrank2.text=Parser.instance.jugadoresranking[1].nombre;
		nomrank3.text=Parser.instance.jugadoresranking[2].nombre;
		nomrank4.text=Parser.instance.jugadoresranking[3].nombre;
		nomrank5.text=Parser.instance.jugadoresranking[4].nombre;
	}

	void OnEnable(){
		nomrank1.text=Parser.instance.jugadoresranking[0].nombre;
		nomrank2.text=Parser.instance.jugadoresranking[1].nombre;
		nomrank3.text=Parser.instance.jugadoresranking[2].nombre;
		nomrank4.text=Parser.instance.jugadoresranking[3].nombre;
		nomrank5.text=Parser.instance.jugadoresranking[4].nombre;
	}
}
