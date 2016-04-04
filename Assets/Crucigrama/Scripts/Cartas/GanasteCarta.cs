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

	public int Random1;
	public int Random2;
	public int Random3;

	void Start(){
		Random1 = UnityEngine.Random.Range (0, 4);
		Random2 = UnityEngine.Random.Range (0, 4);
		Random3 = UnityEngine.Random.Range (0, 4);

		Chekeador1 ();
		Chekeador2 ();
		Chekeador3 ();
	}

	//Carta 1
	public void DarVueltaCarta1 () {
		if (PlayerPrefs.GetInt ("DarVuelta1")==0) {
			switch (Random1) {
			case 0:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [0];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 0);
				break;
			case 1:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [1];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 1);
				break;
			case 2:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [2];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 2);
				break;
			case 3:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [3];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 3);
				break;
			case 4:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [4];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 4);
				break;
			case 5:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [5];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 5);
				break;
			case 6:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [6];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 6);
				break;
			case 7:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [7];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 7);
				break;
			case 8:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [8];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 8);
				break;
			case 9:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [9];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 9);
				break;
			case 10:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [10];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 10);
				break;
			case 11:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [11];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 11);
				break;
			case 12:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [12];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 12);
				break;
			case 13:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [13];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 13);
				break;
			case 14:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [14];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 14);
				break;
			case 15:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [15];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 15);
				break;
			case 16:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [16];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 16);
				break;
			case 17:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [17];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 17);
				break;
			case 18:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [18];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 18);
				break;
			case 19:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [19];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 19);
				break;
			case 20:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [20];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 20);
				break;
			case 21:
				Carta1.GetComponent<Image> ().sprite = CartasChicas [21];
				PlayerPrefs.SetInt ("DarVuelta1", 1);
				PlayerPrefs.SetInt ("Ganada1", 21);
				break;

			}
		}
	}

	//Carta 2
	public void DarVueltaCarta2 () {
		if (PlayerPrefs.GetInt ("DarVuelta2")==0) {
			switch (Random2) {
			case 0:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [0];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 0);
				break;
			case 1:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [1];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 1);
				break;
			case 2:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [2];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 2);
				break;
			case 3:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [3];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 3);
				break;
			case 4:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [4];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 4);
				break;
			case 5:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [5];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 5);
				break;
			case 6:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [6];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 6);
				break;
			case 7:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [7];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 7);
				break;
			case 8:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [8];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 8);
				break;
			case 9:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [9];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 9);
				break;
			case 10:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [10];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 10);
				break;
			case 11:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [11];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 11);
				break;
			case 12:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [12];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 12);
				break;
			case 13:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [13];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 13);
				break;
			case 14:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [14];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 14);
				break;
			case 15:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [15];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 15);
				break;
			case 16:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [16];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 16);
				break;
			case 17:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [17];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 17);
				break;
			case 18:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [18];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 18);
				break;
			case 19:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [19];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 19);
				break;
			case 20:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [20];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 20);
				break;
			case 21:
				Carta2.GetComponent<Image> ().sprite = CartasChicas [21];
				PlayerPrefs.SetInt ("DarVuelta2", 1);
				PlayerPrefs.SetInt ("Ganada2", 21);
				break;

			}
		}
	}

	//Carta 3
	public void DarVueltaCarta3 () {
		if (PlayerPrefs.GetInt ("DarVuelta3")==0) {
			switch (Random3) {
			case 0:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [0];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 0);
				break;
			case 1:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [1];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 1);
				break;
			case 2:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [2];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 2);
				break;
			case 3:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [3];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 3);
				break;
			case 4:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [4];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 4);
				break;
			case 5:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [5];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 5);
				break;
			case 6:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [6];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 6);
				break;
			case 7:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [7];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 7);
				break;
			case 8:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [8];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 8);
				break;
			case 9:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [9];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 9);
				break;
			case 10:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [10];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 10);
				break;
			case 11:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [11];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 11);
				break;
			case 12:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [12];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada2", 12);
				break;
			case 13:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [13];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 13);
				break;
			case 14:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [14];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 14);
				break;
			case 15:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [15];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 15);
				break;
			case 16:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [16];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 16);
				break;
			case 17:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [17];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 17);
				break;
			case 18:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [18];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 18);
				break;
			case 19:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [19];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 19);
				break;
			case 20:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [20];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 20);
				break;
			case 21:
				Carta3.GetComponent<Image> ().sprite = CartasChicas [21];
				PlayerPrefs.SetInt ("DarVuelta3", 1);
				PlayerPrefs.SetInt ("Ganada3", 21);
				break;

			}
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
		PlayerPrefs.SetInt ("Ganada1", 22);
		PlayerPrefs.SetInt ("Ganada2", 22);
		PlayerPrefs.SetInt ("Ganada3", 22);
	}
}
