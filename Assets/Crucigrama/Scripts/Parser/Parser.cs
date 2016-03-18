using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using LitJson;

public class Parser : MonoBehaviour {
	private string urlsplash="http://www.malditosnerds.com/crucigramas/front/splash.php";
	private string urlcrucigramas="http://www.malditosnerds.com/crucigramas/front/crucigramas.php";
	private string jsoncrucigramas;
	private string jsonsplash;
	private JsonData jsondatacrucigramas;
	private JsonData jsondatasplash;
	public static Parser instance;

	void Awake(){
		DontDestroyOnLoad (this.transform);
		if (instance == null) {
			instance = this;
		}

		//cargamos todos los json y los guardamos para no tener que ir cambiando
		LoadJsons ();
	}
		
	void LoadJsons(){
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
		Debug.Log (sub);
		jsondatacrucigramas = JsonMapper.ToObject (sub);
		//Splash
		www = new WWW(urlsplash);
		yield return www;
		jsonsplash = www.text;
		Debug.Log (jsonsplash);
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
		Debug.Log ("asd");
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
		return splash;
	}

	public Crucigrama GetCrossword(int num){
		Crucigrama cru = new Crucigrama();
		cru.id = jsondatacrucigramas ["crucigramas"][0]["id_crucigrama"].ToString();
		cru.nombre = jsondatacrucigramas ["crucigramas"] [0] ["nombre"].ToString ();
		cru.estado = jsondatacrucigramas ["crucigramas"] [0] ["estado"].ToString ();
		cru.fecha = jsondatacrucigramas ["crucigramas"] [num] ["fecha"].ToString ();
		List<Palabra> palabras = new List<Palabra> ();
		for (int j = 0; j < jsondatacrucigramas ["crucigramas"] [num] ["palabras"].Count; j++) {
			Palabra pal = new Palabra ();
			pal.id=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["id"].ToString ();
			pal.def=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["nombre"].ToString ();
			pal.def=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["def"].ToString ();
			pal.coordx=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["coordx"].ToString ();
			pal.coordy=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["coordy"].ToString ();
			pal.verhor=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["verhor"].ToString ();
			pal.fecha=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["fecha_pal"].ToString ();
			pal.estado=jsondatacrucigramas ["crucigramas"] [num] ["palabras"][j]["estado_pal"].ToString ();
			palabras.Add(pal);
		}
		cru.palabras = palabras.ToArray ();
		return cru;
	}

	public List<Crucigrama> GetAllCrosswords(){
		List<Crucigrama> crucis=new List<Crucigrama>();
		for (int i = 0; i < jsondatacrucigramas ["crucigramas"].Count; i++) {
			Crucigrama cru = new Crucigrama ();
			cru.id = jsondatacrucigramas ["crucigramas"] [i] ["id_crucigrama"].ToString ();
			cru.nombre = jsondatacrucigramas ["crucigramas"] [i] ["nombre"].ToString ();
			cru.estado = jsondatacrucigramas ["crucigramas"] [i] ["estado"].ToString ();
			cru.fecha = jsondatacrucigramas ["crucigramas"] [i] ["fecha"].ToString ();
			crucis.Add (cru);
		}
		return crucis;
	}
}
