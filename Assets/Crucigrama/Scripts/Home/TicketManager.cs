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

	void Start(){
		cont=0;
		index=0;
		Invoke ("Empezar",2);
	}

	void Empezar () {
		ListaTicket = Parser.instance.Tickets ();
		for (int i = 0; i < ListaTicket.Count; i++) {
			grandtexto+=ListaTicket[i]+"       ";
			TicketFrase.text=grandtexto.Substring(0,largo);
			//TicketFrase.text = ListaTicket [i].texto;

			switch (ListaTicket [i].estado) {
			case "0":
				Debug.Log("No disponible");
				break;
			case "1":
				Debug.Log("Disponible");
				break;
			}
		}
	}

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
			TicketFrase.text=sub;

		}
	}
}
