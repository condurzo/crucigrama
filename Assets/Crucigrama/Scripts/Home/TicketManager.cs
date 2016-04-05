using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TicketManager : MonoBehaviour {
	public List<Ticket> ListaTicket= new List<Ticket> ();
	public Text TicketFrase;

	private string grandtexto;
	public float tiempo;
	public int largo;
	private float cont;
	private int index;
	private bool startt;
	public string grandtextolong;
	//&ntilde;       &aacute;       &ntilde;       &aacute;       &ntilde;       &aacute;       &ntilde;       &aacute;       &ntilde;       &aacute;       &ntilde;       &aacute;       &ntilde;       &aacute;       
	void Start () {
		startt=false;
		cont=0;
		index=0;
		Debug.Log(Parser.instance.Tickets().Count);
		ListaTicket =Parser.instance.Tickets();
		for (int i = 0; i < ListaTicket.Count; i++) {
			grandtexto+=ListaTicket[i].texto+"       ";
		}
		grandtexto=grandtexto.Replace("&ntilde;","ñ");
		grandtexto=grandtexto.Replace("&Ntilde;","Ñ");
		grandtexto=grandtexto.Replace("&aacute;","á");
		grandtexto=grandtexto.Replace("&eacute;","é");
		grandtexto=grandtexto.Replace("&iacute;","í");
		grandtexto=grandtexto.Replace("&oacute;","ó");
		grandtexto=grandtexto.Replace("&uacute;","ú");
		grandtexto=grandtexto.Replace("&Aacute;","Á");
		grandtexto=grandtexto.Replace("&Eacute;","É");
		grandtexto=grandtexto.Replace("&Iacute;","Í");
		grandtexto=grandtexto.Replace("&Oacute;","Ó");
		grandtexto=grandtexto.Replace("&Uacute;","Ú");
		grandtextolong=grandtexto+grandtexto+grandtexto+grandtexto+grandtexto+grandtexto+grandtexto;
		if(largo>grandtexto.Length){
			TicketFrase.text=grandtextolong.Substring(0,largo);
		}else{
			TicketFrase.text=grandtexto.Substring(0,largo);
		}
		startt=true;
	}

	void Update () {
		if(startt){
		cont+=Time.deltaTime;
		if(cont>=tiempo){
			cont=0;
			index++;
			if(index>grandtexto.Length){
				index=0;
			}
			string sub="";
				string grandtextolong=grandtexto+grandtexto+grandtexto+grandtexto+grandtexto+grandtexto+grandtexto;
			if((index+largo)>grandtexto.Length){
				sub=grandtextolong.Substring(index,largo);
			}else{
				sub=grandtexto.Substring(index,largo);
			}
			TicketFrase.text=sub;
		}
		}
	}
}
