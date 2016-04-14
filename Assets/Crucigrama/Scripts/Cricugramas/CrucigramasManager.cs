using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CrucigramasManager : MonoBehaviour {
	public List<Crucigrama> ListaCruci = new List<Crucigrama> ();
	public GameObject CruciPrefab;
	public Sprite sp0;

	void Start () {
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
			crucishow.id = ListaCruci.Count-i;
			crucishow.estado.text = estado;
			crucishow.thumburl=ListaCruci[i].thumburl;
			LayoutElement lay = go.GetComponent<LayoutElement> ();
			lay.preferredHeight = Screen.height / 20;
			if (i == 0) {
				lay.preferredHeight = lay.preferredHeight * 2;
				crucishow.imagen.sprite = sp0;
			}
		}
	}
}
