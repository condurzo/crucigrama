using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Marquesina : MonoBehaviour {
	public Text texto;
	public string[] palabras;
	private string grandtexto;
	public float tiempo;
	public int largo;
	private float cont;
	private int index;

	void Start () {
		cont=0;
		index=0;
		for(int i=0;i<palabras.Length;i++){
			grandtexto+=palabras[i]+"       ";
		}
		texto.text=grandtexto.Substring(0,largo);
	}
	
	// Update is called once per frame
	void Update () {
		cont+=Time.deltaTime;
		if(cont>=tiempo){
			cont=0;
			index++;
			if(index>grandtexto.Length){
				index=0;
			}
			string sub="";
			string grandtextolong=grandtexto+grandtexto;
			if((index+largo)>grandtexto.Length){
				sub=grandtextolong.Substring(index,largo);
			}else{
				sub=grandtexto.Substring(index,largo);
			}
			texto.text=sub;

		}
	}
}
