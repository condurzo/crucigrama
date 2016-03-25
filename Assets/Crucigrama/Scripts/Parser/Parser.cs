using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using LitJson;
using System;

public class Parser : MonoBehaviour {
	private string urlsplash="http://www.malditosnerds.com/crucigramas/front/splash.php";
	private string urlcrucigramas="http://www.malditosnerds.com/crucigramas/front/crucigramas.php";
	private string jsoncrucigramas;
	public string jsonsplash;
	private JsonData jsondatacrucigramas;
	private JsonData jsondatasplash;
	public static Parser instance;

	void Awake(){
		DontDestroyOnLoad (this.transform);
		if (instance == null) {
			instance = this;
		}
		//cargamos todos los json y los guardamos para no tener que ir cambiando
		StartCoroutine ("GetJsons");
	}

	IEnumerator GetJsons(){
		//Crucigramas
		WWW www = new WWW(urlcrucigramas);
		yield return www;
		jsoncrucigramas = www.text;
		int first = jsoncrucigramas.IndexOf ('>');
		int last=jsoncrucigramas.LastIndexOf('<');
		string sub = jsoncrucigramas.Substring (first+1,(last-first)-1);
		jsondatacrucigramas = JsonMapper.ToObject (sub);
		//Splash
		www = new WWW(urlsplash);
		yield return www;
		jsonsplash = www.text;
		jsondatasplash = JsonMapper.ToObject (jsonsplash);
	}


	public Splash GetSplash (int num){
		Splash spla = new Splash();
		spla.id_splash = jsondatasplash["splash"][num]["id_splash"].ToString();
		spla.posicion = jsondatasplash["splash"][num]["posicion"].ToString();
		spla.segundos = jsondatasplash["splash"][num]["segundos"].ToString();
		spla.estado = jsondatasplash["splash"][num]["estado"].ToString();
		spla.cover = jsondatasplash["splash"][num]["cover"].ToString();
		return spla;
	}

	public List<Splash> GetAllSplash(){
		List<Splash> splash =new List<Splash>();
		for (int i = 0; i < (jsondatasplash ["splash"]).Count; i++) {
			Splash spla = new Splash ();
			spla.id_splash = jsondatasplash["splash"][i]["id_splash"].ToString();
			spla.posicion = jsondatasplash["splash"][i]["posicion"].ToString();
			spla.segundos = jsondatasplash["splash"][i]["segundos"].ToString();
			spla.estado = jsondatasplash["splash"][i]["estado"].ToString();
			spla.cover = jsondatasplash["splash"][i]["cover"].ToString();
			splash.Add (spla);
		}
		splash.Sort ((IComparer<Splash>)new SplashSort ());
		return splash;
	}

	public Crucigrama GetCrossword(int num){
		Crucigrama cru = new Crucigrama();
		cru.id = jsondatacrucigramas ["crucigramas"][num]["id_crucigrama"].ToString();
		cru.nombre = jsondatacrucigramas ["crucigramas"] [num] ["nombre"].ToString ();
		cru.estado = jsondatacrucigramas ["crucigramas"] [num] ["estado"].ToString ();
		cru.fecha = jsondatacrucigramas ["crucigramas"] [num] ["fecha"].ToString ();
		List<Palabra> palabras = new List<Palabra> ();
		for (int j = 0; j < jsondatacrucigramas ["crucigramas"] [num] ["palabras"].Count; j++) {
			Palabra pal = new Palabra ();
			pal.id=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["id"].ToString ();
			pal.nom=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["nom"].ToString ();
			pal.def=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["def"].ToString ();
			pal.coordx=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["coorx"].ToString ();
			pal.coordy=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["coory"].ToString ();
			pal.verhor=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["verhor"].ToString ();
			pal.fecha=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["fecha_pal"].ToString ();
			pal.estado=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["estado_pal"].ToString ();
			palabras.Add(pal);
		}
		cru.palabras = palabras.ToArray ();
		return cru;
	}

	public void RegistrarUsuario(string idsocial_jugador,string nom_jugador,string email_jugador,string pass_jugador="1",string estado_jugador="1",string tipo_jugador="1",string pendiente_asignar="1"){
		string fecha_jugador=DateTime.Now.ToString("s");
		string url = "http://www.malditosnerds.com/crucigramas/front/jugador_registrar.php?idsocial_jugador="+idsocial_jugador+"&nom_jugador="+nom_jugador+"&email_jugador="+email_jugador+"&pass_jugador="+pass_jugador+"&estado_jugador="+estado_jugador+"&tipo_jugador="+tipo_jugador+"&fecha_jugador="+fecha_jugador+"&pendiente_asignar="+pendiente_asignar;
		WWW www = new WWW (url);
		Debug.Log ("registre usuario: " + nom_jugador);
	}

	public List<Crucigrama> GetAllCrosswords(){
		List<Crucigrama> crucis=new List<Crucigrama>();
		for (int i = 0; i < jsondatacrucigramas ["crucigramas"].Count; i++) {
			Crucigrama cru = new Crucigrama ();
			cru.id = jsondatacrucigramas ["crucigramas"] [i] ["id_crucigrama"].ToString ();
			cru.nombre = jsondatacrucigramas ["crucigramas"] [i] ["nombre"].ToString ();
			cru.estado = jsondatacrucigramas ["crucigramas"] [i] ["estado"].ToString ();
			cru.fecha = jsondatacrucigramas ["crucigramas"] [i] ["fecha"].ToString ();
			List<Palabra> palabras = new List<Palabra> ();
			for (int j = 0; j < jsondatacrucigramas ["crucigramas"] [i] ["palabras"].Count; j++) {
				Palabra pal = new Palabra ();
				pal.id=jsondatacrucigramas ["crucigramas"] [i] ["palabras"][j]["id"].ToString ();
				pal.nom=jsondatacrucigramas ["crucigramas"] [i] ["palabras"][j]["nom"].ToString ();
				pal.def=jsondatacrucigramas ["crucigramas"] [i] ["palabras"][j]["def"].ToString ();
				pal.coordx=jsondatacrucigramas ["crucigramas"] [i] ["palabras"][j]["coorx"].ToString ();
				pal.coordy=jsondatacrucigramas ["crucigramas"] [i] ["palabras"][j]["coory"].ToString ();
				pal.verhor=jsondatacrucigramas ["crucigramas"] [i] ["palabras"][j]["verhor"].ToString ();
				pal.fecha=jsondatacrucigramas ["crucigramas"] [i] ["palabras"][j]["fecha_pal"].ToString ();
				pal.estado=jsondatacrucigramas ["crucigramas"] [i] ["palabras"][j]["estado_pal"].ToString ();
				palabras.Add(pal);
			}
			cru.palabras = palabras.ToArray();
			crucis.Add (cru);
		}
		crucis.Sort ((IComparer<Crucigrama>)new CrosswordSort ());
		return crucis;
	}
}


public class SplashSort : IComparer<Splash>{
	int IComparer<Splash>.Compare(Splash a, Splash b) {
		return a.posicion.CompareTo(b.posicion);
	}
}

public class CrosswordSort : IComparer<Crucigrama>{
	int IComparer<Crucigrama>.Compare(Crucigrama a, Crucigrama b) {
		int aid = 0;
		bool ab=int.TryParse (a.id,out aid);
		int bid = 0;
		bool bb=int.TryParse (b.id,out bid);
		return bid.CompareTo(aid);
	}
}
