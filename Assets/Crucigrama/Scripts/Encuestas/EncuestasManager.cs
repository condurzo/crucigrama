using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EncuestasManager : MonoBehaviour {

    public List<Crucigrama> ListaCruci = new List<Crucigrama>();
    public GameObject CruciPrefab;

    void Start()
    {
        Invoke("Empezar", 2);
    }

    void Empezar()
    {
        ListaCruci = Parser.instance.GetAllCrosswords();
        for (int i = 0; i < ListaCruci.Count; i++)
        {
            GameObject go = Instantiate(CruciPrefab) as GameObject;
            go.transform.parent = gameObject.transform;
            LayoutElement lay = go.GetComponent<LayoutElement>();
            lay.preferredHeight = Screen.height / 14;
            
        }
    }
}
