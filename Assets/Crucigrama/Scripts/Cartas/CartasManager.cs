using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CartasManager : MonoBehaviour {

    public GameObject CartaShow;

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

    void Start(){
      
        if (PlayerPrefs.GetInt("Carta22") == 0){
            _Carta22.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta01") == 0){
            _Carta01.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta02") == 0){
            _Carta02.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta03") == 0){
            _Carta03.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta04") == 0){
            _Carta04.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta05") == 0){
            _Carta05.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta06") == 0){
            _Carta06.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta07") == 0){
            _Carta07.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta08") == 0){
            _Carta08.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta09") == 0){
            _Carta09.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta10") == 0){
            _Carta10.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta11") == 0){
            _Carta11.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta12") == 0){
            _Carta12.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta13") == 0){
            _Carta13.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta14") == 0){
            _Carta14.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta15") == 0){
            _Carta15.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta16") == 0){
            _Carta16.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta17") == 0){
            _Carta17.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta18") == 0){
            _Carta18.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta19") == 0){
            _Carta19.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta20") == 0){
            _Carta20.GetComponent<Image>().sprite = CartaDorso;
        }
        if (PlayerPrefs.GetInt("Carta21") == 0){
            _Carta21.GetComponent<Image>().sprite = CartaDorso;
        }

    }

    
    public void CartaGrande22 (){
        if (PlayerPrefs.GetInt("Carta22") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta22;
        }
	}
    public void CartaGrande01(){
        if (PlayerPrefs.GetInt("Carta01") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta01;
        }
    }
    public void CartaGrande02(){
        if (PlayerPrefs.GetInt("Carta02") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta02;
        }
    }
    public void CartaGrande03(){
        if (PlayerPrefs.GetInt("Carta03") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta03;
        }
    }
    public void CartaGrande04(){
        if (PlayerPrefs.GetInt("Carta04") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta04;
        }
    }
    public void CartaGrande05(){
        if (PlayerPrefs.GetInt("Carta05") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta05;
        }
    }
    public void CartaGrande06(){
        if (PlayerPrefs.GetInt("Carta06") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta06;
        }
    }
    public void CartaGrande07(){
        if (PlayerPrefs.GetInt("Carta07") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta07;
        }
    }
    public void CartaGrande08(){
        if (PlayerPrefs.GetInt("Carta08") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta08;
        }
    }
    public void CartaGrande09(){
        if (PlayerPrefs.GetInt("Carta09") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta09;
        }
    }
    public void CartaGrande10(){
        if (PlayerPrefs.GetInt("Carta10") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta10;
        }
    }
    public void CartaGrande11(){
        if (PlayerPrefs.GetInt("Carta11") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta11;
        }
    }
    public void CartaGrande12(){
        if (PlayerPrefs.GetInt("Carta12") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta12;
        }
    }
    public void CartaGrande13(){
        if (PlayerPrefs.GetInt("Carta13") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta13;
        }
    }
    public void CartaGrande14(){
        if (PlayerPrefs.GetInt("Carta14") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta14;
        }
    }
    public void CartaGrande15(){
        if (PlayerPrefs.GetInt("Carta15") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta15;
        }
    }
    public void CartaGrande16(){
        if (PlayerPrefs.GetInt("Carta16") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta16;
        }
    }
    public void CartaGrande17(){
        if (PlayerPrefs.GetInt("Carta17") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta17;
        }
    }
    public void CartaGrande18(){
        if (PlayerPrefs.GetInt("Carta18") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta18;
        }
    }
    public void CartaGrande19(){
        if (PlayerPrefs.GetInt("Carta19") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta19;
        }
    }
    public void CartaGrande20(){
        if (PlayerPrefs.GetInt("Carta20") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta20;
        }
    }
    public void CartaGrande21(){
        if (PlayerPrefs.GetInt("Carta21") == 1){
            CartaShow.SetActive(true);
            CartaGrande.GetComponent<Image>().sprite = Carta21;
        }
    }
}
