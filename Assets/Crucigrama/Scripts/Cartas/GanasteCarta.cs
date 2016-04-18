using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GanasteCarta : MonoBehaviour {

	public Sprite[] CartasChicas;

	public Image Carta1;
	public Image Carta2;
	public Image Carta3;

	public Button AceptarBtn;
	public Sprite AceptarON;

	public static int Random1;
	public static int Random2;
	public static int Random3;

	public GameObject Home;
	public GameObject CrucigramaSeccion;
	public GameObject EncuestaSeccion;
	public GameObject CartasSeccion;
	public GameObject Tabs;
	public TabsOrden Orden;

	void Start(){
		if (PlayerPrefs.GetInt ("Reinicie") == 1) {
			Home.SetActive (false);
			CartasSeccion.SetActive (true);
			CrucigramaSeccion.SetActive (false);
			EncuestaSeccion.SetActive (false);
			Tabs.SetActive (true);
			Orden.EnCartas ();
			PlayerPrefs.SetInt ("Reinicie", 0);
		}

		if ((PlayerPrefs.GetString ("c4") == "a")||(PlayerPrefs.GetString ("c4") == "")||(PlayerPrefs.GetString ("c4") == "0")) {
			Random1 = UnityEngine.Random.Range (0, 22);
			Random2 = UnityEngine.Random.Range (0, 22);
			Random3 = UnityEngine.Random.Range (0, 22);

		}

		//Chekeador1 ();
		//Chekeador2 ();
		//Chekeador3 ();

	}

	//Carta 1
	public void DarVueltaCarta1 () {
		//if (PlayerPrefs.GetInt ("DarVuelta1")==0) {
			switch (Random1) {
			case 0:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [22];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 22);
				PlayerPrefs.SetString("Carta22", "1");
				break;
			case 1:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [1];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 1);
			PlayerPrefs.SetString("Carta1", "1");
				break;
			case 2:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [2];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 2);
			PlayerPrefs.SetString("Carta2", "1");
				break;
			case 3:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [3];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 3);
			PlayerPrefs.SetString("Carta3", "1");
				break;
			case 4:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [4];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 4);
			PlayerPrefs.SetString("Carta4", "1");
				break;
			case 5:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [5];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 5);
			PlayerPrefs.SetString("Carta5", "1");
				break;
			case 6:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [6];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 6);
			PlayerPrefs.SetString("Carta6", "1");
				break;
			case 7:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [7];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 7);
			PlayerPrefs.SetString("Carta7", "1");
				break;
			case 8:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [8];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 8);
			PlayerPrefs.SetString("Carta8", "1");
				break;
			case 9:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [9];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 9);
			PlayerPrefs.SetString("Carta9", "1");
				break;
			case 10:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [10];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 10);
			PlayerPrefs.SetString("Carta10", "1");
				break;
			case 11:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [11];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 11);
			PlayerPrefs.SetString("Carta11", "1");
				break;
			case 12:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [12];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 12);
			PlayerPrefs.SetString("Carta12", "1");
				break;
			case 13:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [13];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 13);
			PlayerPrefs.SetString("Carta13", "1");
				break;
			case 14:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [14];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 14);
			PlayerPrefs.SetString("Carta14", "1");
				break;
			case 15:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [15];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 15);
			PlayerPrefs.SetString("Carta15", "1");
				break;
			case 16:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [16];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 16);
			PlayerPrefs.SetString("Carta16", "1");
				break;
			case 17:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [17];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 17);
			PlayerPrefs.SetString("Carta17", "1");
				break;
			case 18:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [18];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 18);
			PlayerPrefs.SetString("Carta18", "1");
				break;
			case 19:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [19];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 19);
			PlayerPrefs.SetString("Carta19", "1");
				break;
			case 20:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [20];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 20);
			PlayerPrefs.SetString("Carta20", "1");
				break;
			case 21:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [21];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 21);
			PlayerPrefs.SetString("Carta21", "1");
				break;

			//}
		}
	}

	//Carta 2
	public void DarVueltaCarta2 () {
		//if (PlayerPrefs.GetInt ("DarVuelta2")==0) {
			switch (Random2) {
			case 0:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [22];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 22);
			PlayerPrefs.SetString("Carta22", "1");
				break;
			case 1:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [1];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 1);
			PlayerPrefs.SetString("Carta1", "1");
				break;
			case 2:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [2];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 2);
			PlayerPrefs.SetString("Carta2", "1");
				break;
			case 3:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [3];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 3);
			PlayerPrefs.SetString("Carta3", "1");
				break;
			case 4:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [4];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 4);
			PlayerPrefs.SetString("Carta4", "1");
				break;
			case 5:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [5];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 5);
			PlayerPrefs.SetString("Carta5", "1");
				break;
			case 6:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [6];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 6);
			PlayerPrefs.SetString("Carta6", "1");
				break;
			case 7:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [7];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 7);
			PlayerPrefs.SetString("Carta7", "1");
				break;
			case 8:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [8];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 8);
			PlayerPrefs.SetString("Carta8", "1");
				break;
			case 9:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [9];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 9);
			PlayerPrefs.SetString("Carta9", "1");
				break;
			case 10:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [10];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 10);
			PlayerPrefs.SetString("Carta010", "1");
				break;
			case 11:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [11];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 11);
			PlayerPrefs.SetString("Carta11", "1");
				break;
			case 12:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [12];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 12);
			PlayerPrefs.SetString("Carta12", "1");
				break;
			case 13:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [13];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 13);
			PlayerPrefs.SetString("Carta13", "1");
				break;
			case 14:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [14];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 14);
			PlayerPrefs.SetString("Carta14", "1");
				break;
			case 15:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [15];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 15);
			PlayerPrefs.SetString("Carta15", "1");
				break;
			case 16:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [16];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 16);
			PlayerPrefs.SetString("Carta16", "1");
				break;
			case 17:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [17];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 17);
			PlayerPrefs.SetString("Carta17", "1");
				break;
			case 18:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [18];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 18);
			PlayerPrefs.SetString("Carta18", "1");
				break;
			case 19:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [19];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 19);
			PlayerPrefs.SetString("Carta19", "1");
				break;
			case 20:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [20];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 20);
			PlayerPrefs.SetString("Carta20", "1");
				break;
			case 21:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [21];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 21);
			PlayerPrefs.SetString("Carta21", "1");
				break;

			//}
		}
	}

	//Carta 3
	public void DarVueltaCarta3 () {
		//if (PlayerPrefs.GetInt ("DarVuelta3")==0) {
			switch (Random3) {
			case 0:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [22];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 22);
			PlayerPrefs.SetString("Carta22", "1");
				break;
			case 1:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [1];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 1);
			PlayerPrefs.SetString("Carta1", "1");
				break;
			case 2:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [2];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 2);
			PlayerPrefs.SetString("Carta2", "1");
				break;
			case 3:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [3];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 3);
			PlayerPrefs.SetString("Carta3", "1");
				break;
			case 4:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [4];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 4);
			PlayerPrefs.SetString("Carta4", "1");
				break;
			case 5:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [5];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 5);
			PlayerPrefs.SetString("Carta5", "1");
				break;
			case 6:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [6];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 6);
			PlayerPrefs.SetString("Carta6", "1");
				break;
			case 7:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [7];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 7);
			PlayerPrefs.SetString("Carta7", "1");
				break;
			case 8:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [8];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 8);
			PlayerPrefs.SetString("Carta8", "1");
				break;
			case 9:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [9];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 9);
			PlayerPrefs.SetString("Carta9", "1");
				break;
			case 10:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [10];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 10);
			PlayerPrefs.SetString("Carta10", "1");
				break;
			case 11:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [11];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 11);
			PlayerPrefs.SetString("Carta11", "1");
				break;
			case 12:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [12];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada2", 12);
			PlayerPrefs.SetString("Carta12", "1");
				break;
			case 13:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [13];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 13);
			PlayerPrefs.SetString("Carta13", "1");
				break;
			case 14:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [14];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 14);
			PlayerPrefs.SetString("Carta14", "1");
				break;
			case 15:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [15];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 15);
			PlayerPrefs.SetString("Carta15", "1");
				break;
			case 16:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [16];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 16);
			PlayerPrefs.SetString("Carta16", "1");
				break;
			case 17:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [17];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 17);
			PlayerPrefs.SetString("Carta17", "1");
				break;
			case 18:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [18];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 18);
			PlayerPrefs.SetString("Carta18", "1");
				break;
			case 19:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [19];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 19);
			PlayerPrefs.SetString("Carta19", "1");
				break;
			case 20:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [20];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 20);
			PlayerPrefs.SetString("Carta20", "1");
				break;
			case 21:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [21];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 21);
			PlayerPrefs.SetString("Carta21", "1");
				break;

			//}
		}
	}

	void Chekeador1(){
		int Ganada1 = PlayerPrefs.GetInt ("Ganada1");
		switch (Ganada1) {
		case 0:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [0];
			break;
		case 1:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [1];
			break;
		case 2:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [2];
			break;
		case 3:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [3];
			break;
		case 4:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [4];
			break;
		case 5:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [5];
			break;
		case 6:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [6];
			break;
		case 7:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [7];
			break;
		case 8:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [8];
			break;
		case 9:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [9];
			break;
		case 10:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [10];
			break;
		case 11:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [11];
			break;
		case 12:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [12];
			break;
		case 13:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [13];
			break;
		case 14:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [14];
			break;
		case 15:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [15];
			break;
		case 16:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [16];
			break;
		case 17:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [17];
			break;
		case 18:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [18];
			break;
		case 19:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [19];
			break;
		case 20:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [20];
			break;
		case 21:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [21];
			break;
		case 22:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [22];
			break;
		}
	}

	void Chekeador2(){
		int Ganada2 = PlayerPrefs.GetInt ("Ganada2");
		switch (Ganada2) {
		case 0:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [0];
			break;
		case 1:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [1];
			break;
		case 2:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [2];
			break;
		case 3:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [3];
			break;
		case 4:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [4];
			break;
		case 5:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [5];
			break;
		case 6:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [6];
			break;
		case 7:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [7];
			break;
		case 8:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [8];
			break;
		case 9:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [9];
			break;
		case 10:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [10];
			break;
		case 11:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [11];
			break;
		case 12:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [12];
			break;
		case 13:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [13];
			break;
		case 14:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [14];
			break;
		case 15:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [15];
			break;
		case 16:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [16];
			break;
		case 17:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [17];
			break;
		case 18:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [18];
			break;
		case 19:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [19];
			break;
		case 20:
			Carta1.GetComponent<Image> ().sprite = CartasChicas [20];
			break;
		case 21:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [21];
			break;
		case 22:
			Carta2.GetComponent<Image> ().sprite = CartasChicas [22];
			break;
		}
	}

	void Chekeador3(){
		int Ganada3 = PlayerPrefs.GetInt ("Ganada3");
		switch (Ganada3) {
		case 0:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [0];
			break;
		case 1:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [1];
			break;
		case 2:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [2];
			break;
		case 3:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [3];
			break;
		case 4:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [4];
			break;
		case 5:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [5];
			break;
		case 6:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [6];
			break;
		case 7:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [7];
			break;
		case 8:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [8];
			break;
		case 9:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [9];
			break;
		case 10:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [10];
			break;
		case 11:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [11];
			break;
		case 12:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [12];
			break;
		case 13:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [13];
			break;
		case 14:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [14];
			break;
		case 15:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [15];
			break;
		case 16:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [16];
			break;
		case 17:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [17];
			break;
		case 18:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [18];
			break;
		case 19:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [19];
			break;
		case 20:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [20];
			break;
		case 21:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [21];
			break;
		case 22:
			Carta3.GetComponent<Image> ().sprite = CartasChicas [22];
			break;
		}
	}

	void Randons(){
		if (PlayerPrefs.GetString ("c4") == "0") {
			if (Random2 == Random1) {
				Random2 = UnityEngine.Random.Range (0, 22);
				return;
			}
			if (Random3 == Random2) {
				Random2 = UnityEngine.Random.Range (0, 22);
				return;
			}
			if (Random3 == Random1) {
				Random3 = UnityEngine.Random.Range (0, 22);
				return;
			}
			PlayerPrefs.SetInt ("Random1", Random1);
			PlayerPrefs.SetInt ("Random2", Random2);
			PlayerPrefs.SetInt ("Random3", Random3);
		}
	}

	void Update () {
		Randons ();
		//Activar Aceptar
		if ((PlayerPrefs.GetInt ("DarVuelta1") == 1) && (PlayerPrefs.GetInt ("DarVuelta2") == 1) && (PlayerPrefs.GetInt ("DarVuelta3") == 1)) {
			AceptarBtn.GetComponent<Button> ().interactable = true;
			AceptarBtn.GetComponent<Image> ().sprite = AceptarON;
		}
	}

	public void Aceptar(){
		PlayerPrefs.SetInt ("DarVuelta1", 0);
		PlayerPrefs.SetInt ("DarVuelta2", 0);
		PlayerPrefs.SetInt ("DarVuelta3", 0);
		PlayerPrefs.SetInt ("Ganada1", 0);
		PlayerPrefs.SetInt ("Ganada2", 0);
		PlayerPrefs.SetInt ("Ganada3", 0);
		PlayerPrefs.SetInt ("MostrarCartaShow", 0);
		PlayerPrefs.SetInt ("Random1", 25);
		PlayerPrefs.SetInt ("Random2", 25);
		PlayerPrefs.SetInt ("Random3", 25);
		PlayerPrefs.SetInt ("EnvieDatos", 0);
		PlayerPrefs.SetInt ("Reinicie", 1);
		PlayerPrefs.SetInt ("SetearCosas", 0);
		PlayerPrefs.SetInt ("SetearCosas2", 0);
		PlayerPrefs.SetInt ("SetearCosas3", 0);

		//poner los C en 0
		string idTemp = PlayerPrefs.GetString ("IdPlayer");
		string c1Temp = PlayerPrefs.GetString ("c1");
		string c2Temp = PlayerPrefs.GetString ("c2");
		string c3Temp = PlayerPrefs.GetString ("c3");
		string url = "http://www.malditosnerds.com/crucigramas/front/jugador_carta.php?idjugador="+idTemp+"&idcarta1="+c1Temp+"&idcarta2="+c2Temp+"&idcarta3="+c3Temp+"&estado=1&idcol=9";
		WWW www = new WWW (url);
		PlayerPrefs.SetString ("c1","0");
		PlayerPrefs.SetString ("c2","0");
		PlayerPrefs.SetString ("c3","0");
		PlayerPrefs.SetString ("c4","0");
		Application.LoadLevel ("Home");
	}
}
