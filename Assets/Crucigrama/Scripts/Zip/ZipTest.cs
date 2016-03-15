using UnityEngine;
using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
 
public class ZipTest : MonoBehaviour
{
 	public List<string> texturas;
	private WWW www;
	private bool isUnzipped = false;
	public static float progreso;
	public string fileName;
	public string docPath2;
 
	// Use this for initialization
	void Start ()
	{
		docPath2="";
		fileName="";
		progreso=0;
		//https://dl.dropboxusercontent.com/s/4r1fn0q3c9ipi1y/Archivo.zip?token_hash=AAFvZL3fXNfMpj_5ehmkx1-g2roYQDFGhteluB7E1PhcLw&dl=1
		//string url="https://dl.dropboxusercontent.com/s/y7gobkvy854c8rk/634528935790245609.zip?dl=1&token_hash=AAFZQ4nFW-SZ0zjgBetNEGSDmaHHm2n5jQz5DE2kvY3eOA";
		string url="https://www.dropbox.com/s/0d5lr5f53952ki6/coca.zip?dl=0";
		//string url = "192.168.0.31:8888/Archivo.zip";
		www = new WWW (url);
	}
 
	// Update is called once per frame
	void Update ()
	{
		//this.gameObject.transform.eulerAngles+=new Vector3(0,2,0);
		if (www.isDone && !isUnzipped) {
			byte[] data = www.bytes;
			string docPath =  Application.persistentDataPath;
			
			docPath += "/Test.zip";
			File.WriteAllBytes (docPath, data);
			
			using (ZipInputStream s = new ZipInputStream(File.OpenRead(docPath))) {
				ZipEntry theEntry;
				
				while ((theEntry = s.GetNextEntry()) != null) {
					Console.WriteLine (theEntry.Name);
					string directoryName = Path.GetDirectoryName (theEntry.Name);
					//string directoryName = "El";
					Debug.Log(directoryName);
					fileName = Path.GetFileName (theEntry.Name);
					Debug.Log(fileName);
					// create directory
					if (directoryName.Length > 0) {
						GetComponent<Renderer>().material.color=Color.black;
						Directory.CreateDirectory (directoryName);
					}
					if (fileName != String.Empty) {
						//string filename = docPath;
						//filename += theEntry.Name;
						docPath2=docPath;
						docPath2 = docPath2.Substring(0, docPath2.Length - 5);
            			docPath2 = docPath2.Substring(0, docPath2.LastIndexOf("/"));
						using (FileStream streamWriter = File.Create(docPath2+"/"+fileName)) {
							int size = 2048;
							byte[] fdata = new byte[2048];
							while (true) {
								size = s.Read (fdata, 0, fdata.Length);
								if (size > 0) {
									streamWriter.Write (fdata, 0, size);
								} else {
									break;
								}
							}
						}
						if(!fileName.StartsWith(".")){
							texturas.Add(fileName);
						}else{
							System.IO.File.Delete(Application.persistentDataPath+fileName);
						}	
					}
				}
				isUnzipped = true;
				System.IO.File.Delete(docPath);
				Debug.LogWarning("TERMINE");
				Cargar.cargado=true;
			}
		}else{
			if(www.progress<1){
				progreso=www.progress*100;
			}else{
				progreso=100;
			}
		}
	}
	
	
}