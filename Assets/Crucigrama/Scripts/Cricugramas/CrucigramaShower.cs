using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CrucigramaShower : MonoBehaviour {
	public Button boton;
	public Image imagenfondo;
	public Image imagen;
	public Text Nombre;
	public Text palabras;
	public Text estado;
	public int id;
	public string thumburl;

	void Awake(){
		boton.onClick.AddListener(delegate() { Prender(); });
		if(thumburl!=""){
			CargarImagen();
		}
	}

	void Start(){
		StartCoroutine("CargarImagen");
	}

	public void Resolver(){
		Managerhome.instance.CargarCruci (id-1);
		Managerhome.instance.CargarRanking(id-1);
	}

	public void Prender(){
		GameObject go = Managerhome.instance.crucigramago;
		go.SetActive (true);
	}

	IEnumerator CargarImagen() {
		WWW www = new WWW(thumburl);
		// Wait for download to complete
		yield return www;
		Texture2D textura=www.texture;
		Sprite spri=Sprite.Create(textura,new Rect(0,0,textura.width,textura.height),new Vector2(0.5f,0.5f));
		imagen.sprite=spri;
	}
}
