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
	private List<string> palabrasUser=new List<string>();
	private int index;
	public GameObject crucigramago;
	private List<Gridcell> gridcells=new List<Gridcell>();
	public GameObject parse;
	public GameObject crucigramaparent;
	private List<int> indextotal=new List<int>();
	public static int palabraescribiendo;
	public List<List<int>> palabrasgrid=new List<List<int>>();
	public Color coloractivo;
	public GameObject Enviando;
	public GameObject Errores;
	public Text ErroresText;

	void Awake (){
		palabraescribiendo=0;
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

	public void cambiarfrase(){
		index=palabraescribiendo;
		Debug.Log(index);
		Debug.Log(frases.Count);
		frasetext.text = frases [index];

		foreach(Gridcell grid in gridcells){
			grid.imagen.color=Color.white;
		}
		foreach(int intt in palabrasgrid[index]){
			gridcells[intt].imagen.color=coloractivo;
		}
	}

	public void CargarCruci(int id){
		indextotal.Clear();
		palabraescribiendo=0;
		gridcells.Clear();
		palabrasgrid.Clear();
		frases.Clear ();
		palabras.Clear();
		palabrasUser.Clear();
		Debug.Log(crucigramaparent.activeSelf);
		for(int i=0;i<400;i++){
			Gridcell grid=crucigramaparent.transform.FindChild("Button ("+i.ToString()+")").gameObject.GetComponent<Gridcell>();
			gridcells.Add(grid);
		}
		Debug.Log("asd");
		foreach(Gridcell grid in gridcells){
			grid.Reset();
			grid.prendido=false;
			grid.Actualizar();
		}
		Cruciactual = Parser.instance.GetCrossword (id);

		for (int i = 0; i < Cruciactual.palabras.Length; i++) {
			//if(Cruciactual.palabras[i].estado=="1"){
			if(Cruciactual.resuelto == "1"){
				frases.Add (Cruciactual.palabras [i].def);
			}else{
				frases.Add ("Palabras "+(i+1).ToString());
			}
			palabras.Add(Cruciactual.palabras[i]);
			palabrasUser.Add("");
		}
		GenerarCruci();
		index = 0;
		if(frases.Count>0){
			if(frases.Count>=index){
				frasetext.text = frases [index];
			}
		}
		cambiarfrase();
	}

	public void Siguiente(){
		Debug.Log("siguiente");
		palabraescribiendo++;
		if (palabraescribiendo > frases.Count-1) {
			palabraescribiendo = 0;
		}
		Debug.Log("SIG: "+palabraescribiendo.ToString());
		cambiarfrase();
	}

	public void Anterior(){
		Debug.Log("anterior");
		palabraescribiendo--;
		if (palabraescribiendo < 0) {
			palabraescribiendo = frases.Count-1;
		}
		cambiarfrase();
	}

	public void GenerarCruci(){
		foreach(Palabra st in palabras){
			Debug.Log(st.palabra);
		}
		for(int i=0;i<palabras.Count;i++){
			Palabra pal=palabras[i];
			prenderpalabra(pal.coordx,pal.coordy,pal.verhor,pal.palabra.ToUpper(),i);
		}
	}

	public void enviar(){
		int correctas=0;
		int incorrectas=0;
		for(int i=0;i<palabrasUser.Count;i++){
			if((palabrasUser[i].ToUpper())==(palabras[i].palabra.ToUpper())){
				correctas++;
			}else{
				incorrectas++;
			}
		}
		if(correctas>=palabrasUser.Count){
			//TERMINASTE EL CRUCI
			if (PlayerPrefs.GetInt ("MostrarCartaShow") == 0) {
				Enviando.SetActive (true);
				PlayerPrefs.SetInt ("MostrarCartaShow", 1);
			}
			Debug.Log("GANASTE");
		}else{
			//TENES "INCORRECTAS"
			Errores.SetActive(true);
			ErroresText.text = incorrectas.ToString ();
			Debug.Log("Incorrectas: "+incorrectas.ToString());
		}
	}

	public void Teclado(string charr){
		Debug.Log("TEcla "+charr);
		Debug.Log(palabraescribiendo);
		if(palabraescribiendo!=-1){
			if(charr=="borrar"){
				if(palabrasUser[palabraescribiendo].Length>0){
					palabrasUser[palabraescribiendo]=palabrasUser[palabraescribiendo].Substring(0,palabrasUser[palabraescribiendo].Length-1);
				}
			}else{
				if(palabrasUser[palabraescribiendo].Length<palabrasgrid[palabraescribiendo].Count){
					palabrasUser[palabraescribiendo]=palabrasUser[palabraescribiendo]+charr.ToUpper();
				}
			}

			string pal=palabrasUser[palabraescribiendo];
			List<int> indexes=palabrasgrid[palabraescribiendo];
			while(pal.Length<indexes.Count){
				pal+=" ";
			}
			for(int i=0;i<indexes.Count;i++){
				if((gridcells[indexes[i]].texto==" ")||(gridcells[indexes[i]].texto=="")||(charr=="borrar")){
					gridcells[indexes[i]].texto=pal.Substring(i,1);
					gridcells[indexes[i]].Actualizar();
				}else{
					char[] letras=palabrasUser[palabraescribiendo].ToCharArray();
					letras[i]=gridcells[indexes[i]].texto.ToCharArray()[0];
					string newword="";
					for(int j=0;j<letras.Length;j++){
						newword+=letras[j];
					}
					palabrasUser[palabraescribiendo]=newword;
				}
			}
		}
	}

	public void prenderpalabra(string x,string y,string verhor,string palabra,int indexwordd){
		int xx=0;
		int yy=0;
		int largo=palabra.Length;
		bool bx=int.TryParse(x,out xx);
		bool by=int.TryParse(y,out yy);
		List<Gridcontent> indexes=new List<Gridcontent>();
		List<int> indexint=new List<int>();
		if(verhor=="1"){
			for(int i=0;i<largo;i++){
				int index=xx+((yy+i)*20);
				string st=palabra.Substring(i,1);
				Gridcontent gricont=new Gridcontent();
				gricont.index=index;
				gricont.character=st;
				if(indextotal.Contains(index)){
					gricont.duplicado=true;
				}else{
					gricont.duplicado=false;
					indextotal.Add(index);
				}
				indexes.Add(gricont);
				indexint.Add(gricont.index);

			}
		}else{
			for(int i=0;i<largo;i++){
				int index=(xx+i)+(yy*20);
				string st=palabra.Substring(i,1);
				Gridcontent gricont=new Gridcontent();
				gricont.index=index;
				gricont.character=st;
				if(indextotal.Contains(index)){
					gricont.duplicado=true;
				}else{
					gricont.duplicado=false;
					indextotal.Add(index);
				}
				indexes.Add(gricont);
				indexint.Add(gricont.index);
			}
		}

		foreach(Gridcontent intt in indexes){
			gridcells[intt.index].prendido=true;
			gridcells[intt.index].texto="";
			gridcells[intt.index].indexword=indexwordd;
			gridcells[intt.index].duplicado=intt.duplicado;
			gridcells[intt.index].Actualizar();
		}
		palabrasgrid.Add(indexint);
		indexes.Clear();
	}
}
