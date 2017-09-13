using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingUnidades : MonoBehaviour {

    public static ArrayList unidades = new ArrayList();
    public GameObject[] prefabsUnidades;
    public GameObject[] rutas;
    public Transform posicionInicial;
    public float factorIncremento;

    // Use this for initialization
    void Start () {

        Vector3 incremento = Vector3.left * factorIncremento;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < prefabsUnidades.Length; j++)
            {
                
                Vector3 siguientePosicion = posicionInicial.position + incremento * (prefabsUnidades.Length * i + j);
                GameObject nuevaUnidad = Instantiate(prefabsUnidades[j], siguientePosicion, Quaternion.identity);
                nuevaUnidad.GetComponentInChildren<Unidad>().ruta = rutas[j];

                unidades.Add(nuevaUnidad);


            }

        }
    
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
/*     GameObject unidad = GameObject.Find("Ferret2"); //GameObject.FindWithTag("unidad");
       GameObject temp;
       Vector3 incremento = new Vector3( -2 , 0);
       Vector3 posicion_actual = unidad.transform.position;

       for (int i = 0; i < 10 ; i++)
       {
           temp = (GameObject)Instantiate(unidad, posicion_actual + incremento, Quaternion.identity);
           posicion_actual = temp.transform.position;
           unidades.Add(temp);
       }*/
