using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class SplashDownloader : MonoBehaviour {

	//LUCAS
	IEnumerator Start() {
		WWW www = new WWW("http://leslieannetarabella.com/wp-content/uploads/2012/09/coca-cola-main-design.jpg.w300h311.jpg");
		yield return www;
		Texture2D texture=www.texture;
		byte[] bytes = texture.EncodeToJPG ();
		File.WriteAllBytes (Application.dataPath + "/splash.jpg", bytes);
	}


//	public UnityEngine.UI.Image myObject;
//	public int width;
//	public int height;
//
//	public void LoadImage(){
//		byte[] bytes = File.ReadAllBytes(Application.persistentDataPath + "/splash.png");
//		Texture2D texture = new Texture2D(900, 900, TextureFormat.RGB24, false);
//		texture.filterMode = FilterMode.Trilinear;
//		texture.LoadImage(bytes);
//		Sprite sprite = Sprite.Create(texture, new Rect(0,0,width, height), new Vector2(0.5f,0.0f), 1.0f);
//		myObject.GetComponent<UnityEngine.UI.Image> ().sprite = sprite;
//	}



//	IEnumerator loadBgImage(string _imgName){
//		string publisherDir = Application.persistentDataPath + "/" + "STATIC.PUBLISER_NAME";
//		string bookDir = Application.persistentDataPath + "/" + "STATIC.PUBLISER_NAME" + "/" + "STATIC.BOOK_ID";
//
//		if (!System.IO.Directory.Exists(publisherDir)){
//			System.IO.Directory.CreateDirectory(publisherDir);
//		}
//
//		if (!System.IO.Directory.Exists(bookDir)){
//			System.IO.Directory.CreateDirectory(bookDir);
//		}
//
//		//WWW www = new WWW("STATIC.BOOK_URL" + "/images/" + _imgName);
//		WWW www = new WWW("http://www.coca-colaproductfacts.com/content/dam/productfacts/us/productDetails/ProductImages/PDP_Coca-Cola_HFCS_glass_8oz.png"+ "/images/" + _imgName);
//
//		yield return www;
//
//		System.IO.File.WriteAllBytes(bookDir + "/" + _imgName, www.bytes);
//	}
//
//	IEnumerator loadBgImage2(UnityEngine.UI.RawImage _targtImg, string _imgName){
//		WWW www = new WWW("file://" + "bookDir" + "/" + _imgName);
//		yield return www;
//		byte[] imgBytes = www.bytes;
//		Texture2D text2d = null;
//		text2d = new Texture2D(16, 16,TextureFormat.PVRTC_RGB2,false);
//		text2d.LoadImage(imgBytes);
//		_targtImg.texture = text2d;
//		RectTransform rect = _targtImg.GetComponent<RectTransform>();
//		if (rect != null){
//			Vector2 offset = Vector2.zero;
//			rect.offsetMin = offset;
//			rect.offsetMax = offset;
//			rect.localScale = Vector3.one;
//		}
//	}



}
