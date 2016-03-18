using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CrucigramasManager : MonoBehaviour {

	public List<Crucigrama> ListaCruci = new List<Crucigrama> ();
	public GameObject CruciPrefab;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			ListaCruci = Parser.instance.GetAllCrosswords ();
			for (int i = 0; i < ListaCruci.Count; i++) {
				Debug.Log(ListaCruci [i].id);
				Debug.Log(ListaCruci [i].nombre);
				CruciPrefab.GetComponentInChildren<Text>().text = ListaCruci [i].nombre;
				GameObject childObject = Instantiate(CruciPrefab) as GameObject;
				childObject.transform.parent = gameObject.transform;
				Crucigrama cruci=childObject.GetComponent<Crucigrama>();
				cruci.id=ListaCruci[i].id;
				cruci.nombre=ListaCruci[i].nombre;
			}
		}
	}
}
