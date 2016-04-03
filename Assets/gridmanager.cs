using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gridmanager : MonoBehaviour {
	public GridLayoutGroup grid;
	public RectTransform recttrans;
	public int ancho;
	public float tamaño;
	public GameObject button;

	void Start () {
		Gridcell[] gridcells=this.gameObject.GetComponentsInChildren<Gridcell>();
		foreach(Gridcell gc in gridcells){
			gc.texto="F";
			gc.prendido=true;
			gc.Actualizar();
		}
		for(int i=0;i<20;i++){
			gridcells[i].gameObject.SetActive(true);
			gridcells[i].texto="R";
			gridcells[i].Actualizar();
		}
	}
	
	void Update () {
	}
}
