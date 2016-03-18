using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;
using System.Globalization;

public class SplashDownloader : MonoBehaviour {
	public Image SplashImagen;

	public string url;

	public List<Splash> ListaSplash = new List<Splash> ();
	private List<Sprite> sprites = new List<Sprite> ();
	private int index;

	//URL Coca: http://m.androidwallpapercentral.com/downloads/1080x1920-wallpaper-Android-CocaCola.jpg
	// URL NIKE: http://cdn29.us1.fansshare.com/pictures/mobilewallpaper/nike-just-do-it-mobile-wallpaper-other-photo-mobile-wallpaper-2135420424.jpg

	void Start(){
		Invoke ("Empezar",2);
	}

	void Empezar(){
		index = 0;
		ListaSplash.Clear ();
		ListaSplash = Parser.instance.GetAllSplash ();
		sprites.Clear ();
		for (int i = 0; i < ListaSplash.Count; i++) {
			StartCoroutine (Guardar (ListaSplash [i].cover, ListaSplash [i].id_splash));
		}
		Invoke ("InicioShow", 2);
	}



	void InicioShow(){
		if (index < ListaSplash.Count) {
			if (ListaSplash [index].estado == "1") {
				SplashImagen.sprite = sprites [index];
				index++;
				if (index < ListaSplash.Count) {
					Invoke ("InicioShow", float.Parse (ListaSplash [index].segundos, CultureInfo.InvariantCulture.NumberFormat));
				}  else {
					Application.LoadLevel (1);
				}
			}
		}
	}

	//Guarda las fotos
	IEnumerator Guardar(string url,string nombre) {
		url = url.Replace("\\","");
		WWW www = new WWW(url);
		yield return www;
		Texture2D texture=www.texture;
		byte[] bytes = texture.EncodeToJPG ();
		File.WriteAllBytes (Application.dataPath + "/"+nombre+".jpg", bytes);
		LoadImage (nombre);
	}

	//Carga las fotos
	public void LoadImage(string nombre){
		byte[] bytes = File.ReadAllBytes(Application.dataPath + "/"+nombre+".jpg");
		Texture2D texture = new Texture2D (2, 2);
		texture.LoadImage (bytes);
		texture.filterMode = FilterMode.Trilinear;
		Sprite sprite = Sprite.Create(texture, new Rect(0,0,texture.width, texture.height), new Vector2(0.5f,0.5f));
		SplashImagen.sprite = sprite;
		sprites.Add (sprite);
	}


}
