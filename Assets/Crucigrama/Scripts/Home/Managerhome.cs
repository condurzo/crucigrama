using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using System.Linq;

public class Managerhome : MonoBehaviour {
	public static Managerhome instance;
	public Text frasetext;
	public Text palabrastext;
	private Crucigrama Cruciactual;
	private List<string> frases=new List<string>();
	private List<Palabra> palabras=new List<Palabra>();
	private int index;
	public GameObject crucigramago;
	private List<Gridcell> gridcells=new List<Gridcell>();
	public GameObject parse;
	public GameObject crucigramaparent;

	void Awake (){
		gridcells.Clear();
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
		Debug.Log(crucigramaparent.activeSelf);
		gridcells=crucigramaparent.GetComponentsInChildren<Gridcell>().ToList();
		foreach(Gridcell grid in gridcells){
			grid.texto=" ";
			grid.prendido=false;
			grid.Actualizar();
		}
		Debug.Log ("cargo cruci");
		Cruciactual = Parser.instance.GetCrossword (id);
		frases.Clear ();
		palabras.Clear();
		for (int i = 0; i < Cruciactual.palabras.Length; i++) {
			frases.Add (Cruciactual.palabras [i].def);
			palabras.Add(Cruciactual.palabras[i]);
		}
		GenerarCruci();
		index = 0;
		if(frases.Count>0){
			if(frases.Count>=index){
				Debug.Log(frases.Count);
				Debug.Log(index);
				frasetext.text = frases [index];
				string pal = "Palabras: ";
				for (int i = 0; i < Cruciactual.palabras.Length; i++) {
					pal += ";" + Cruciactual.palabras [i].palabra;
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

	public void GenerarCruci(){
		for(int i=0;i<palabras.Count;i++){
			Palabra pal=palabras[i];
			prenderpalabra(pal.coordx,pal.coordy,pal.verhor,pal.palabra);
		}
	}

	public void prenderpalabra(string x,string y,string verhor,string palabra){
		int xx=0;
		int yy=0;
		int largo=palabra.Length;
		bool bx=int.TryParse(x,out xx);
		bool by=int.TryParse(y,out yy);
		List<Gridcontent> indexes=new List<Gridcontent>();
		if(verhor=="1"){
			for(int i=0;i<largo;i++){
				int index=xx+((yy+i)*20);
				string st=palabra.Substring(i,1);
				Gridcontent gricont=new Gridcontent();
				gricont.index=index;
				gricont.character=st;
				indexes.Add(gricont);
			}
		}else{
			for(int i=0;i<largo;i++){
				int index=(xx+i)+(yy*20);
				string st=palabra.Substring(i,1);
				Gridcontent gricont=new Gridcontent();
				gricont.index=index;
				gricont.character=st;
				indexes.Add(gricont);
			}
		}
		foreach(Gridcontent intt in indexes){
			gridcells[intt.index].prendido=true;
			gridcells[intt.index].texto=intt.character;
			gridcells[intt.index].Actualizar();
		}
		indexes.Clear();
	}
}
