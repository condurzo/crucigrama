using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PremiosManagerHome : MonoBehaviour {
	public Text CrucigramasPremios;
	public Text ColeccionPremios;
	// Use this for initialization
	void Start () {
		Parser.instance.PremiosDisp ();
		CrucigramasPremios.text = PlayerPrefs.GetString ("premiosDisponiblesCrcigramas");
		ColeccionPremios.text = PlayerPrefs.GetString ("premiosDisponiblesColeccion");
	}

	public void ReLoadPremios () {
		Parser.instance.PremiosDisp ();
		CrucigramasPremios.text = PlayerPrefs.GetString ("premiosDisponiblesCrcigramas");
		ColeccionPremios.text = PlayerPrefs.GetString ("premiosDisponiblesColeccion");
	}
	
	// Update is called once per frame
	void Update () {
		//		Debug.Log(PlayerPrefs.GetString ("idColeccionActiva"));
		//		Debug.Log(PlayerPrefs.GetString ("idCrucigramaVigente"));
		//		Debug.Log(PlayerPrefs.GetString ("premiosDisponiblesColeccion"));
		//		Debug.Log(PlayerPrefs.GetString ("premiosDisponiblesCrcigramas"));
	}
}
