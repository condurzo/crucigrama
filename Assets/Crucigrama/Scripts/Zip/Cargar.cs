﻿using UnityEngine;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.IO;

public class Cargar : MonoBehaviour {
	public GameObject obj;
	public string nombre;
	private string result;
	public static bool cargado=false;
	public Texture textura;
	
	IEnumerator Cargar2 () {
		result=obj.GetComponent<ZipTest>().texturas[0];
		string url="file://"+Application.persistentDataPath+"/"+result;
		asd.nombre=url;
		WWW www= new WWW(url);
		yield return www;
		textura=www.texture;
		obj.GetComponent<Renderer>().material.mainTexture=textura;
	}
	void Update(){
		if(cargado){
				asd.nombre=result;
				cargado=false;
				StartCoroutine(Cargar2());
				
				
		}
	}
}
