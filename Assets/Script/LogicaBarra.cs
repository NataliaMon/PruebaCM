using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaBarra : MonoBehaviour {

    public GameObject enemigo;
    public GameObject barraVerde;
    public GameObject barraRoja;
    SpriteRenderer sr;
    public float escala = 0.001f;

    // Use this for initialization
    void Start () {

        sr = barraVerde.GetComponent<SpriteRenderer>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (sr.transform.localScale.x > 0)
        {
            sr.transform.localScale -= new Vector3(escala, 0);
            barraVerde.transform.position = enemigo.transform.position - new Vector3(0.3f - sr.bounds.size.x/2,- 0.4f);
            barraRoja.transform.position = enemigo.transform.position - new Vector3(0.5f, -0.4f);
        }
		
	}
}
