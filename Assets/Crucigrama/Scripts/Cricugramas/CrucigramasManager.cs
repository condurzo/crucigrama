using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CrucigramasManager : MonoBehaviour {

	public List<Crucigrama> ListaCruci = new List<Crucigrama> ();
	public GameObject CruciPrefab;

	void Start(){
		Invoke ("Empezar",2);
	}

	void Empezar () {
		ListaCruci = Parser.instance.GetAllCrosswords ();
		for (int i = 0; i < ListaCruci.Count; i++) {
			GameObject go = Instantiate(CruciPrefab) as GameObject;
			go.transform.parent = gameObject.transform;
			CrucigramaShower crucishow = go.GetComponent<CrucigramaShower> ();
			crucishow.Nombre.text = ListaCruci [i].nombre;
			crucishow.palabras.text = ListaCruci [i].palabras.Length.ToString();
			string estado = "";
			switch (ListaCruci [i].estado) {
				case "0":
					estado = "No disponible";
				break;
				case "1":
					estado= "Disponible";
				break;
			}
			crucishow.id = i;
			crucishow.estado.text = estado;
		}
	}
}
