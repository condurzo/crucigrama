using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CartasManager : MonoBehaviour {

	public GameObject CartaShow; 

	public GameObject CartaShowGanaste;

    public Image CartaGrande;

    public Sprite CartaDorso;
    public Sprite Carta22;
    public Sprite Carta01;
    public Sprite Carta02;
    public Sprite Carta03;
    public Sprite Carta04;
    public Sprite Carta05;
    public Sprite Carta06;
    public Sprite Carta07;
    public Sprite Carta08;
    public Sprite Carta09;
    public Sprite Carta10;
    public Sprite Carta11;
    public Sprite Carta12;
    public Sprite Carta13;
    public Sprite Carta14;
    public Sprite Carta15;
    public Sprite Carta16;
    public Sprite Carta17;
    public Sprite Carta18;
    public Sprite Carta19;
    public Sprite Carta20;
    public Sprite Carta21;

    public Image _Carta22;
    public Image _Carta01;
    public Image _Carta02;
    public Image _Carta03;
    public Image _Carta04;
    public Image _Carta05;
    public Image _Carta06;
    public Image _Carta07;
    public Image _Carta08;
    public Image _Carta09;
    public Image _Carta10;
    public Image _Carta11;
    public Image _Carta12;
    public Image _Carta13;
    public Image _Carta14;
    public Image _Carta15;
    public Image _Carta16;
    public Image _Carta17;
    public Image _Carta18;
    public Image _Carta19;
    public Image _Carta20;
    public Image _Carta21;

	public Sprite CartaC22;
	public Sprite CartaC01;
	public Sprite CartaC02;
	public Sprite CartaC03;
	public Sprite CartaC04;
	public Sprite CartaC05;
	public Sprite CartaC06;
	public Sprite CartaC07;
	public Sprite CartaC08;
	public Sprite CartaC09;
	public Sprite CartaC10;
	public Sprite CartaC11;
	public Sprite CartaC12;
	public Sprite CartaC13;
	public Sprite CartaC14;
	public Sprite CartaC15;
	public Sprite CartaC16;
	public Sprite CartaC17;
	public Sprite CartaC18;
	public Sprite CartaC19;
	public Sprite CartaC20;
	public Sprite CartaC21;

	public bool Activador;

	void Update(){
		
		if (PlayerPrefs.GetString ("c4") == "1") {
			
				string c1 = PlayerPrefs.GetString ("c1");
				string c2 = PlayerPrefs.GetString ("c2");
				string c3 = PlayerPrefs.GetString ("c3");

				GanasteCarta.Random1 = System.Int32.Parse (c1);
				GanasteCarta.Random2 = System.Int32.Parse (c2);
				GanasteCarta.Random3 = System.Int32.Parse (c3);
				CartaShowGanaste.SetActive (true);

		}
	}

	void Start(){
//		Debug.Log("CartaPref1: "+ PlayerPrefs.GetString("Carta1"));
//		Debug.Log("CartaPref2: "+ PlayerPrefs.GetString("Carta2"));
//		Debug.Log("CartaPref3: "+ PlayerPrefs.GetString("Carta3"));
//		Debug.Log("CartaPref4: "+ PlayerPrefs.GetString("Carta4"));
//		Debug.Log("CartaPref5: "+ PlayerPrefs.GetString("Carta5"));
//		Debug.Log("CartaPref6: "+ PlayerPrefs.GetString("Carta6"));
//		Debug.Log("CartaPref7: "+ PlayerPrefs.GetString("Carta7"));
//		Debug.Log("CartaPref8: "+ PlayerPrefs.GetString("Carta8"));	
//		Debug.Log("CartaPref9: "+ PlayerPrefs.GetString("Carta9"));
//		Debug.Log("CartaPref10: "+ PlayerPrefs.GetString("Carta10"));
//		Debug.Log("CartaPref11: "+ PlayerPrefs.GetString("Carta11"));
//		Debug.Log("CartaPref12: "+ PlayerPrefs.GetString("Carta12"));
//		Debug.Log("CartaPref13: "+ PlayerPrefs.GetString("Carta13"));
//		Debug.Log("CartaPref14: "+ PlayerPrefs.GetString("Carta14"));
//		Debug.Log("CartaPref15: "+ PlayerPrefs.GetString("Carta15"));
//		Debug.Log("CartaPref16: "+ PlayerPrefs.GetString("Carta16"));
//		Debug.Log("CartaPref17: "+ PlayerPrefs.GetString("Carta17"));
//		Debug.Log("CartaPref18: "+ PlayerPrefs.GetString("Carta18"));
//		Debug.Log("CartaPref19: "+ PlayerPrefs.GetString("Carta19"));
//		Debug.Log("CartaPref20: "+ PlayerPrefs.GetString("Carta20"));
//		Debug.Log("CartaPref21: "+ PlayerPrefs.GetString("Carta21"));
//		Debug.Log("CartaPref22: "+ PlayerPrefs.GetString("Carta22"));





		if (PlayerPrefs.GetInt ("MostrarCartaShow") == 1) {
			CartaShowGanaste.SetActive (true);
		}
      
		if ((PlayerPrefs.GetString("Carta22") == "0")||(PlayerPrefs.GetString("Carta22") == "")){
            _Carta22.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta1") == "0")||(PlayerPrefs.GetString("Carta1") == "")){
            _Carta01.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta2") == "0")||(PlayerPrefs.GetString("Carta2") == "")){
            _Carta02.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta3") == "0")||(PlayerPrefs.GetString("Carta3") == "")){
            _Carta03.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta4") == "0")||(PlayerPrefs.GetString("Carta4") == "")){
            _Carta04.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta5") == "0")||(PlayerPrefs.GetString("Carta5") == "")){
            _Carta05.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta6") == "0")||(PlayerPrefs.GetString("Carta6") == "")){
            _Carta06.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta7") == "0")||(PlayerPrefs.GetString("Carta7") == "")){
            _Carta07.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta8") == "0")||(PlayerPrefs.GetString("Carta8") == "")){
            _Carta08.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta9") == "0")||(PlayerPrefs.GetString("Carta9") == "")){
            _Carta09.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta10") == "0")||(PlayerPrefs.GetString("Carta10") == "")){
            _Carta10.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta11") == "0")||(PlayerPrefs.GetString("Carta11") == "")){
            _Carta11.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta12") == "0")||(PlayerPrefs.GetString("Carta12") == "")){
            _Carta12.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta13") == "0")||(PlayerPrefs.GetString("Carta13") == "")){
            _Carta13.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta14") == "0")||(PlayerPrefs.GetString("Carta14") == "")){
            _Carta14.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta15") == "0")||(PlayerPrefs.GetString("Carta15") == "")){
            _Carta15.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta16") == "0")||(PlayerPrefs.GetString("Carta16") == "")){
            _Carta16.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta17") == "0")||(PlayerPrefs.GetString("Carta17") == "")){
            _Carta17.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta18") == "0")||(PlayerPrefs.GetString("Carta18") == "")){
            _Carta18.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta19") == "0")||(PlayerPrefs.GetString("Carta19") == "")){
            _Carta19.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta20") == "0")||(PlayerPrefs.GetString("Carta20") == "")){
            _Carta20.GetComponent<Image>().sprite = CartaDorso;
        }
		if ((PlayerPrefs.GetString("Carta21") == "0")||(PlayerPrefs.GetString("Carta21") == "")){
            _Carta21.GetComponent<Image>().sprite = CartaDorso;
        }

    }


	public void SetearCartaGrande(){

		if (PlayerPrefs.GetString("Carta22") == "1"){
			_Carta22.GetComponent<Image>().sprite = CartaC22;
		}
		if (PlayerPrefs.GetString("Carta1") == "1"){
			_Carta01.GetComponent<Image>().sprite = CartaC01;
		}
		if (PlayerPrefs.GetString("Carta2") == "1"){
			_Carta02.GetComponent<Image>().sprite = CartaC02;
		}
		if (PlayerPrefs.GetString("Carta3") == "1"){
			_Carta03.GetComponent<Image>().sprite = CartaC03;
		}
		if (PlayerPrefs.GetString("Carta4") == "1"){
			_Carta04.GetComponent<Image>().sprite = CartaC04;
		}
		if (PlayerPrefs.GetString("Carta5") == "1"){
			_Carta05.GetComponent<Image>().sprite = CartaC05;
		}
		if (PlayerPrefs.GetString("Carta6") == "1"){
			_Carta06.GetComponent<Image>().sprite = CartaC06;
		}
		if (PlayerPrefs.GetString("Carta7") == "1"){
			_Carta07.GetComponent<Image>().sprite = CartaC07;
		}
		if (PlayerPrefs.GetString("Carta8") == "1"){
			_Carta08.GetComponent<Image>().sprite = CartaC08;
		}
		if (PlayerPrefs.GetString("Carta9") == "1"){
			_Carta09.GetComponent<Image>().sprite = CartaC09;
		}
		if (PlayerPrefs.GetString("Carta10") == "1"){
			_Carta10.GetComponent<Image>().sprite = CartaC10;
		}
		if (PlayerPrefs.GetString("Carta11") == "1"){
			_Carta11.GetComponent<Image>().sprite = CartaC11;
		}
		if (PlayerPrefs.GetString("Carta12") == "1"){
			_Carta12.GetComponent<Image>().sprite = CartaC12;
		}
		if (PlayerPrefs.GetString("Carta13") == "1"){
			_Carta13.GetComponent<Image>().sprite = CartaC13;
		}
		if (PlayerPrefs.GetString("Carta14") == "1"){
			_Carta14.GetComponent<Image>().sprite = CartaC14;
		}
		if (PlayerPrefs.GetString("Carta15") == "1"){
			_Carta15.GetComponent<Image>().sprite = CartaC15;
		}
		if (PlayerPrefs.GetString("Carta16") == "1"){
			_Carta16.GetComponent<Image>().sprite = CartaC16;
		}
		if (PlayerPrefs.GetString("Carta17") == "1"){
			_Carta17.GetComponent<Image>().sprite = CartaC17;
		}
		if (PlayerPrefs.GetString("Carta18") == "1"){
			_Carta18.GetComponent<Image>().sprite = CartaC18;
		}
		if (PlayerPrefs.GetString("Carta19") == "1"){
			_Carta19.GetComponent<Image>().sprite = CartaC19;
		}
		if (PlayerPrefs.GetString("Carta20") == "1"){
			_Carta20.GetComponent<Image>().sprite = CartaC20;
		}
		if (PlayerPrefs.GetString("Carta21") == "1"){
			_Carta21.GetComponent<Image>().sprite = CartaC21;
		}

	}
    
    public void CartaGrande22 (){
		if (PlayerPrefs.GetString("Carta22") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta22;
			PlayerPrefs.SetInt ("ShareCarta", 22);
        }
	}
    public void CartaGrande01(){
		if (PlayerPrefs.GetString("Carta1") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta01;
			PlayerPrefs.SetInt ("ShareCarta", 01);
        }
    }
    public void CartaGrande02(){
		if (PlayerPrefs.GetString("Carta2") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta02;
			PlayerPrefs.SetInt ("ShareCarta", 02);
        }
    }
    public void CartaGrande03(){
		if (PlayerPrefs.GetString("Carta3") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta03;
			PlayerPrefs.SetInt ("ShareCarta", 03);
        }
    }
    public void CartaGrande04(){
		if (PlayerPrefs.GetString("Carta4") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta04;
			PlayerPrefs.SetInt ("ShareCarta", 04);
        }
    }
    public void CartaGrande05(){
		if (PlayerPrefs.GetString("Carta5") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta05;
			PlayerPrefs.SetInt ("ShareCarta", 05);
        }
    }
    public void CartaGrande06(){
		if (PlayerPrefs.GetString("Carta6") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta06;
			PlayerPrefs.SetInt ("ShareCarta", 06);
        }
    }
    public void CartaGrande07(){
		if (PlayerPrefs.GetString("Carta7") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta07;
			PlayerPrefs.SetInt ("ShareCarta", 07);
        }
    }
    public void CartaGrande08(){
		if (PlayerPrefs.GetString("Carta8") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta08;
			PlayerPrefs.SetInt ("ShareCarta", 08);
        }
    }
    public void CartaGrande09(){
		if (PlayerPrefs.GetString("Carta9") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta09;
			PlayerPrefs.SetInt ("ShareCarta", 09);
        }
    }
    public void CartaGrande10(){
		if (PlayerPrefs.GetString("Carta10") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta10;
			PlayerPrefs.SetInt ("ShareCarta", 10);
        }
    }
    public void CartaGrande11(){
		if (PlayerPrefs.GetString("Carta11") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta11;
			PlayerPrefs.SetInt ("ShareCarta", 11);
        }
    }
    public void CartaGrande12(){
		if (PlayerPrefs.GetString("Carta12") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta12;
			PlayerPrefs.SetInt ("ShareCarta", 12);
        }
    }
    public void CartaGrande13(){
		if (PlayerPrefs.GetString("Carta13") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta13;
			PlayerPrefs.SetInt ("ShareCarta", 13);
        }
    }
    public void CartaGrande14(){
		if (PlayerPrefs.GetString("Carta14") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta14;
			PlayerPrefs.SetInt ("ShareCarta", 14);
        }
    }
    public void CartaGrande15(){
		if (PlayerPrefs.GetString("Carta15") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta15;
			PlayerPrefs.SetInt ("ShareCarta", 15);
        }
    }
    public void CartaGrande16(){
		if (PlayerPrefs.GetString("Carta16") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta16;
			PlayerPrefs.SetInt ("ShareCarta", 16);
        }
    }
    public void CartaGrande17(){
		if (PlayerPrefs.GetString("Carta17") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta17;
			PlayerPrefs.SetInt ("ShareCarta", 17);
        }
    }
    public void CartaGrande18(){
		if (PlayerPrefs.GetString("Carta18") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta18;
			PlayerPrefs.SetInt ("ShareCarta", 18);
        }
    }
    public void CartaGrande19(){
		if (PlayerPrefs.GetString("Carta19") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta19;
			PlayerPrefs.SetInt ("ShareCarta", 19);
        }
    }
    public void CartaGrande20(){
		if (PlayerPrefs.GetString("Carta20") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta20;
			PlayerPrefs.SetInt ("ShareCarta", 20);
        }
    }
    public void CartaGrande21(){
		if (PlayerPrefs.GetString("Carta21") == "1"){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta21;
			PlayerPrefs.SetInt ("ShareCarta", 21);
        }
    }
}
