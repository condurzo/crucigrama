using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;

public class SplashDownloader : MonoBehaviour {
	public UnityEngine.UI.Image SplashImagen;
	public int width;
	public int height;

	public List<Image> ListaSplash;


	// URL NIKE: http://cdn29.us1.fansshare.com/pictures/mobilewallpaper/nike-just-do-it-mobile-wallpaper-other-photo-mobile-wallpaper-2135420424.jpg

	//LUCAS
	IEnumerator Start() {
		WWW www = new WWW("http://m.androidwallpapercentral.com/downloads/1080x1920-wallpaper-Android-CocaCola.jpg");
		yield return www;
		Texture2D texture=www.texture;
		byte[] bytes = texture.EncodeToJPG ();
		File.WriteAllBytes (Application.dataPath + "/splash.jpg", bytes);
		LoadImage();
	}

	public void LoadImage(){
		byte[] bytes = File.ReadAllBytes(Application.dataPath + "/splash.jpg");
		Texture2D texture = new Texture2D(1080, 1920, TextureFormat.RGB24, false);
		texture.filterMode = FilterMode.Trilinear;
		texture.LoadImage(bytes);
		Sprite sprite = Sprite.Create(texture, new Rect(0,0,width, height), new Vector2(0.5f,0.0f), 1.0f);
		SplashImagen.GetComponent<UnityEngine.UI.Image> ().sprite = sprite;
	}


}
