using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using LitJson;
using System;

public class Parser : MonoBehaviour {
	public List<string> Urls=new List<string>();

	private List<string> jsontxts=new List<string>();
	private List<JsonData> jsondatas= new List<JsonData>();
	public static Parser instance;
	private string idsocial;
	public static string idplayer;
	public string IdTemp;
	/*/
	ORDEN
	0-Splash
	1-Crucigrama
	2-premios
	3-ticket
	4-version
	/*/

	void Awake(){
		DontDestroyOnLoad (this.transform);
		if (instance == null) {
			instance = this;
		}
		//cargamos todos los json y los guardamos para no tener que ir cambiando
		StartCoroutine ("GetJsons");
	}

	void Update(){
		if(Input.GetKeyUp(KeyCode.A)){
			Debug.Log(GetVersion());
		}
	}

	IEnumerator GetJsons(){
		for(int i=0;i<Urls.Count;i++){
			WWW www = new WWW(Urls[i]);
			yield return www;
			jsontxts.Add(www.text);
			int first = jsontxts[i].IndexOf ('>');
			int last=jsontxts[i].LastIndexOf('<');
			string sub = "";
			if ((first >= 0) && (last >= 0)) {
				sub = jsontxts[i].Substring (first + 1, (last - first) - 1);
			} else {
				sub=jsontxts[i];
			}
			JsonData jsondata = JsonMapper.ToObject (sub);
			jsondatas.Add(jsondata);
		}
	}



	public Splash GetSplash (int num){
		Splash spla = new Splash();
		spla.id_splash = jsondatas[0]["splash"][num]["id_splash"].ToString();
		spla.posicion = jsondatas[0]["splash"][num]["posicion"].ToString();
		spla.segundos = jsondatas[0]["splash"][num]["segundos"].ToString();
		spla.estado = jsondatas[0]["splash"][num]["estado"].ToString();
		spla.cover = jsondatas[0]["splash"][num]["cover"].ToString();
		spla.nombre = jsondatas[0]["splash"][num]["nombre"].ToString();
		return spla;
	}

	public List<Splash> GetAllSplash(){
		List<Splash> splash =new List<Splash>();
		for (int i = 0; i < (jsondatas[0] ["splash"]).Count; i++) {
			Splash spla = new Splash ();
			spla.id_splash = jsondatas[0]["splash"][i]["id_splash"].ToString();
			spla.posicion = jsondatas[0]["splash"][i]["posicion"].ToString();
			spla.segundos = jsondatas[0]["splash"][i]["segundos"].ToString();
			spla.estado = jsondatas[0]["splash"][i]["estado"].ToString();
			spla.cover = jsondatas[0]["splash"][i]["cover"].ToString();
			spla.nombre = jsondatas[0]["splash"][i]["nombre"].ToString();
			splash.Add (spla);
		}
		splash.Sort ((IComparer<Splash>)new SplashSort ());
		return splash;
	}

	public List<Premio> Premios(){
		List<Premio> premi=new List<Premio>();
		for (int i = 0; i < jsondatas[2] ["premios"].Count; i++) {
			Premio pre = new Premio ();
			pre.id = jsondatas[2] ["premios"] [i] ["id"].ToString ();
			pre.nombre = jsondatas[2] ["premios"] [i] ["nombre"].ToString ();
			pre.url=jsondatas[2] ["premios"] [i] ["imagen"].ToString ();
			premi.Add (pre);
		}
		return premi;
	}

	public List<Ticket> Tickets(){
		List<Ticket> ticke=new List<Ticket>();
		for (int i = 0; i < jsondatas[3] ["tickets"].Count; i++) {
			Ticket tic = new Ticket ();
			tic.id = jsondatas[3] ["tickets"] [i] ["id_ticket"].ToString ();
			tic.nombre = jsondatas[3] ["tickets"] [i] ["nombre"].ToString ();
			tic.texto = jsondatas[3] ["tickets"] [i] ["texto"].ToString ();
			tic.posicion = jsondatas[3] ["tickets"] [i] ["posicion"].ToString ();
			tic.ubicacion = jsondatas[3] ["tickets"] [i] ["ubicacion"].ToString ();
			tic.estado = jsondatas[3] ["tickets"] [i] ["estado"].ToString ();
			ticke.Add (tic);
		}
		return ticke;
	}

	public string GetVersion(){
		string versionactual="0.0.0";
		for (int j = 0; j < jsondatas[4]["versiones"].Count; j++) {
			if(jsondatas[4]["versiones"][j]["f"].ToString()=="1"){
				return jsondatas[4]["versiones"][j]["v"].ToString();
			}

		}

		return versionactual;
	}

	public Crucigrama GetCrossword(int num){
		Crucigrama cru = new Crucigrama();
		cru.id = jsondatas[1] ["crucigramas"][num]["id_crucigrama"].ToString();
		cru.nombre = jsondatas[1] ["crucigramas"] [num] ["nombre"].ToString ();
		cru.estado = jsondatas[1] ["crucigramas"] [num] ["estado"].ToString ();
		cru.resuelto = jsondatas[1] ["crucigramas"] [num] ["resuelto"].ToString ();
		cru.fecha = jsondatas[1] ["crucigramas"] [num] ["fecha"].ToString ();
		cru.numpremios = jsondatas[1] ["crucigramas"] [num] ["numpremios"].ToString ();
		List<Palabra> palabras = new List<Palabra> ();
		for (int j = 0; j < jsondatas[1] ["crucigramas"] [num] ["palabras"].Count; j++) {
			Palabra pal = new Palabra ();
			pal.id=jsondatas[1] ["crucigramas"] [num] ["palabras"][j]["id"].ToString ();
			pal.palabra=jsondatas[1] ["crucigramas"] [num] ["palabras"][j]["nom"].ToString ();
			pal.def=jsondatas[1] ["crucigramas"] [num] ["palabras"][j]["def"].ToString ();
			pal.coordx=jsondatas[1] ["crucigramas"] [num] ["palabras"][j]["coorx"].ToString ();
			pal.coordy=jsondatas[1] ["crucigramas"] [num] ["palabras"][j]["coory"].ToString ();
			pal.verhor=jsondatas[1] ["crucigramas"] [num] ["palabras"][j]["verhor"].ToString ();
			pal.fecha=jsondatas[1] ["crucigramas"] [num] ["palabras"][j]["fecha_pal"].ToString ();
			pal.estado=jsondatas[1] ["crucigramas"] [num] ["palabras"][j]["estado_pal"].ToString ();
			palabras.Add(pal);
		}
		cru.palabras = palabras.ToArray ();
		return cru;
	}

	public void RegistrarUsuario(string idsocial_jugador,string nom_jugador,string email_jugador,string pass_jugador="1",string estado_jugador="1",string tipo_jugador="1",string pendiente_asignar="1"){
		string fecha_jugador=DateTime.Now.ToString("s");
		nom_jugador=nom_jugador.Replace(" ","-");
		string url = "http://www.malditosnerds.com/crucigramas/front/jugador_registrar.php?idsocial_jugador="+idsocial_jugador+"&nom_jugador="+nom_jugador+"&email_jugador="+email_jugador+"&pass_jugador="+pass_jugador+"&estado_jugador="+estado_jugador+"&tipo_jugador="+tipo_jugador+"&fecha_jugador="+fecha_jugador+"&pendiente_asignar="+pendiente_asignar;
		WWW www = new WWW (url);
		Debug.Log ("registre usuario: " + nom_jugador);
        Debug.Log("URL " + url);
		ObtenerIDCorutine ();
		//PlayerPrefs.SetInt ("Registrado", 1);
	}
		
	IEnumerator ObtenerID(string IDFace){
		WWW www = new WWW ("http://www.malditosnerds.com/crucigramas/front/jugador_check.php?idsocial_jugador=" + IDFace + "&tipo=1");
		yield return www;
		string id = www.text;
		JsonData jsonIDJugador = JsonMapper.ToObject (www.text);
		idplayer=jsonIDJugador["resultado"].ToString();
		PlayerPrefs.SetString ("IdPlayer",idplayer);
		Debug.Log ("ID Jugadro: " + PlayerPrefs.GetString("IdPlayer"));
	}

	public void ObtenerIDCorutine(){
		IdTemp = PlayerPrefs.GetString ("IdFacebook");
		StartCoroutine(ObtenerID(IdTemp));
	}

	public EstadoJugador EstadoJugadorObtener(string IDplayer){
		string urlE = "http://www.malditosnerds.com/crucigramas/front/cartasactivas.php?idjugador=" + IDplayer;
		WWW www = new WWW (urlE);
		EstadoJugador estJug = new EstadoJugador ();
		while(www.isDone){
		string txtEstJug = www.text;
		JsonData jsonEstadoJugador = JsonMapper.ToObject (txtEstJug);


			estJug.id = jsonEstadoJugador ["jugador"] [0] ["id"].ToString();
			estJug.c1 = jsonEstadoJugador ["jugador"] [0] ["c1"].ToString();
			estJug.c2 = jsonEstadoJugador ["jugador"] [0] ["c2"].ToString();
			estJug.c3 = jsonEstadoJugador ["jugador"] [0] ["c3"].ToString();
			estJug.c4 = jsonEstadoJugador ["jugador"] [0] ["c4"].ToString();
		
		}
		return estJug;
	}

//	public void EstadoJugadorCorutine(){
//		string idJugador = PlayerPrefs.GetString("IdPlayer");
//		StartCoroutine (EstadoJugadorObtener (idJugador));
//	}

	public List<Jugador> Ranking(string idcrucigrama,string idjugador){
		string url = "http://www.malditosnerds.com/crucigramas/front/ranking_cruci2.php?idcruci="+idcrucigrama+"&idjugador="+idjugador;
		WWW www = new WWW (url);
	//yield return www;
		string txtjson=www.text;
		int first = txtjson.IndexOf ('>');
		int last=	txtjson.LastIndexOf('<');
		string sub = "";
		if ((first >= 0) && (last >= 0)) {
			sub = txtjson.Substring (first + 1, (last - first) - 1);
		} else {
			sub=txtjson;
		}
		JsonData jsondatanew = JsonMapper.ToObject (sub);

		List<Jugador> jugadoresrank=new List<Jugador>();
		for(int i=0;i<jsondatanew["rankings"].Count;i++){
			Jugador jug =new Jugador();
			jug.puesto=jsondatanew["rankings"][i]["puesto"].ToString();
			jug.nombre=jsondatanew["rankings"][i]["nombre"].ToString();
			jug.fecha=jsondatanew["rankings"][i]["fecha_resuelto"].ToString();
			jug.id=jsondatanew["rankings"][i]["id_jugador"].ToString();
			jugadoresrank.Add(jug);
		}
		return jugadoresrank;
	}

	public List<Crucigrama> GetAllCrosswords(){
		List<Crucigrama> crucis=new List<Crucigrama>();
		for (int i = 0; i < jsondatas[1] ["crucigramas"].Count; i++) {
			Crucigrama cru = new Crucigrama ();
			cru.id = jsondatas[1] ["crucigramas"] [i] ["id_crucigrama"].ToString ();
			cru.nombre = jsondatas[1] ["crucigramas"] [i] ["nombre"].ToString ();
			cru.estado = jsondatas[1] ["crucigramas"] [i] ["estado"].ToString ();
			cru.fecha = jsondatas[1] ["crucigramas"] [i] ["fecha"].ToString ();
			List<Palabra> palabras = new List<Palabra> ();
			for (int j = 0; j < jsondatas[1] ["crucigramas"] [i] ["palabras"].Count; j++) {
				Palabra pal = new Palabra ();
				pal.id=jsondatas[1] ["crucigramas"] [i] ["palabras"][j]["id"].ToString ();
				pal.palabra=jsondatas[1] ["crucigramas"] [i] ["palabras"][j]["nom"].ToString ();
				pal.def=jsondatas[1] ["crucigramas"] [i] ["palabras"][j]["def"].ToString ();
				pal.coordx=jsondatas[1] ["crucigramas"] [i] ["palabras"][j]["coorx"].ToString ();
				pal.coordy=jsondatas[1] ["crucigramas"] [i] ["palabras"][j]["coory"].ToString ();
				pal.verhor=jsondatas[1] ["crucigramas"] [i] ["palabras"][j]["verhor"].ToString ();
				pal.fecha=jsondatas[1] ["crucigramas"] [i] ["palabras"][j]["fecha_pal"].ToString ();
				pal.estado=jsondatas[1] ["crucigramas"] [i] ["palabras"][j]["estado_pal"].ToString ();
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
