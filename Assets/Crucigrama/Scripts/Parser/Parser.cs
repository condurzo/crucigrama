using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using LitJson;

public class Parser : MonoBehaviour {
	private string json;
	private JsonData jsondata;

	private List<Crucigrama> crucis=new List<Crucigrama>();
	public List<Crucigrama> crucigramas;


	private List<Splash> splash =new List<Splash>();
	public List<Splash> splashes;

	void Start(){
		//LoadJson ();  //Crucigramas
		LoadJsonSplash(); //Splash
	}

	void Update(){
//		if (Input.GetKeyDown (KeyCode.Space)) {
//			//tenes uno para pedir especificamente uno o sino uno para pedir todos(no trae las palarbas ahI)
//			Crucigrama crumi = GetCrossword (0);
//			Debug.Log (crumi.id);
//			Debug.Log (crumi.nombre);
//			Debug.Log (crumi.estado);
//		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			Splash spla = GetSplash (0);
			Debug.Log (spla.id_splash);
			Debug.Log (spla.posicion);
			Debug.Log (spla.segundos);
			Debug.Log (spla.estado);
			Debug.Log (spla.cover);
		}
	}



	////SPLASH
	void LoadJsonSplash(){
		StartCoroutine ("GetJsonSplash");
	}

	public Splash GetSplash (int num){
		Splash spla = new Splash();
		spla.id_splash = jsondata["splashes"][0]["id_splash"].ToString();
		spla.posicion = jsondata["splashes"][0]["posicion"].ToString();
		spla.segundos = jsondata["splashes"][0]["segundos"].ToString();
		spla.estado = jsondata["splashes"][0]["estado"].ToString();
		spla.cover = jsondata["splashes"][0]["cover"].ToString();
		return spla;
	}

	public List<Splash> GetAllSplash(){
		List<Splash> splash =new List<Splash>();
		for (int i = 0; i < jsondata ["splashes"].Count; i++) {
			Splash spla = new Splash ();
			spla.id_splash = jsondata["splashes"][i]["id_splash"].ToString();
			spla.posicion = jsondata["splashes"][i]["posicion"].ToString();
			spla.segundos = jsondata["splashes"][i]["segundos"].ToString();
			spla.estado = jsondata["splashes"][i]["estado"].ToString();
			spla.cover = jsondata["splashes"][i]["cover"].ToString();
			splash.Add (spla);
		}
		return splash;
	}

	IEnumerator GetJsonSplash(){
		WWW www = new WWW("http://www.malditosnerds.com/crucigramas/front/splash.php");
		yield return www;
		json = www.text;
		jsondata = JsonMapper.ToObject (json);
	}
	////END SPLASH



	////CRUCIGRAMAS
//	void LoadJson(){
//		StartCoroutine ("GetJson");
//	}
//
//	public Crucigrama GetCrossword(int num){
//		Crucigrama cru = new Crucigrama();
//		cru.id = jsondata ["crucigramas"][0]["id_crucigrama"].ToString();
//		cru.nombre = jsondata ["crucigramas"] [0] ["nombre"].ToString ();
//		cru.estado = jsondata ["crucigramas"] [0] ["estado"].ToString ();
//		cru.fecha = jsondata ["crucigramas"] [num] ["fecha"].ToString ();
//		List<Palabra> palabras = new List<Palabra> ();
//
//		//ACA COMO NO ES UN ARRAY NO PUEDO ITERAR
//
//		for (int j = 0; j < jsondata ["crucigramas"] [num] ["palabras"].Count; j++) {
//			Palabra pal = new Palabra ();
//			pal.id=jsondata ["crucigramas"] [num] ["palabras"][j]["id"].ToString ();
//			pal.def=jsondata ["crucigramas"] [num] ["palabras"][j]["def"].ToString ();
//			pal.coordx=jsondata ["crucigramas"] [num] ["palabras"][j]["coordx"].ToString ();
//			pal.coordy=jsondata ["crucigramas"] [num] ["palabras"][j]["coordy"].ToString ();
//			pal.verhor=jsondata ["crucigramas"] [num] ["palabras"][j]["verhor"].ToString ();
//			pal.fecha=jsondata ["crucigramas"] [num] ["palabras"][j]["fecha_pal"].ToString ();
//			pal.estado=jsondata ["crucigramas"] [num] ["palabras"][j]["estado_pal"].ToString ();
//			palabras.Add(pal);
//		}
//		cru.palabras = palabras.ToArray ();
//		return cru;
//	}
//
//	public List<Crucigrama> GetAllCrosswords(){
//		List<Crucigrama> crucis=new List<Crucigrama>();
//		for (int i = 0; i < jsondata ["crucigramas"].Count; i++) {
//			Crucigrama cru = new Crucigrama ();
//			cru.id = jsondata ["crucigramas"] [i] ["id_crucigrama"].ToString ();
//			cru.nombre = jsondata ["crucigramas"] [i] ["nombre"].ToString ();
//			cru.estado = jsondata ["crucigramas"] [i] ["estado"].ToString ();
//			cru.fecha = jsondata ["crucigramas"] [i] ["fecha"].ToString ();
//			crucis.Add (cru);
//		}
//		return crucis;
//	}
//
//	IEnumerator GetJson(){
//		WWW www = new WWW("http://www.malditosnerds.com/crucigramas/front/crucigramas.php");
//		yield return www;
//		json = www.text;
//		jsondata = JsonMapper.ToObject (json);
//	}
	//// END CRUCIGRAMAS
}
