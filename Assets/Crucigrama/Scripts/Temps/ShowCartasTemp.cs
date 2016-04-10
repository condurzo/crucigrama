using UnityEngine;
using System.Collections;

public class ShowCartasTemp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
			if (PlayerPrefs.GetString ("c4") == "0") {
				if (PlayerPrefs.GetInt ("EnvieDatos") == 0) {
					string idJugador = PlayerPrefs.GetString ("IdPlayer");
					string idCrucigrama = PlayerPrefs.GetString ("IdCrucigrama");
					string _Valor1 = PlayerPrefs.GetInt ("Random1").ToString ();
					string _Valor2 = PlayerPrefs.GetInt ("Random2").ToString ();
					string _Valor3 = PlayerPrefs.GetInt ("Random3").ToString ();
					string url = "http://www.malditosnerds.com/crucigramas/front/jugador_estado_crucigrama_cartas.php?idjugador=" + idJugador + "&idcruci=" + idCrucigrama + "&estado=1&valor1=" + _Valor1 + "&valor2=" + _Valor2 + "&valor3=" + _Valor3 + "&valor4=1";
					WWW www = new WWW (url);
					Debug.Log (url);
					Invoke ("NoMostrar", 3);
				}

		}
	}
	
	// Update is called once per frame
	void NoMostrar () {
		PlayerPrefs.SetInt ("EnvieDatos", 1);
	}
}
