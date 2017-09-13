using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidad : MonoBehaviour {

    public GameObject ruta;
    private int indice;
    private Vector3 posicion_actual;
    private Vector3 posicion_siguiente;
    public float vel = 1;
    private float distancia_punto = 0.1f;
    //private bool esta_viva;

    
    
    /*Especificaciones del video2 Mov Ruta:
      public GameObject ruta;
      private int indice;
      private float tiempo;*/

    // Use this for initialization
    void Start() {

    posicion_actual = this.transform.position;
    posicion_siguiente = ruta.transform.GetChild(0).position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (esta_viva)
        {*/
            Vector3 dir = posicion_siguiente - transform.position;
            transform.position += dir.normalized * vel * Time.deltaTime;

            if (dir.magnitude <= distancia_punto)
            {
                if (indice + 1 < ruta.transform.childCount)
                {
                    indice++;
                    posicion_siguiente = ruta.transform.GetChild(indice).position;
                    //Debug.Log("xs"+posicion_siguiente.x+"ys"+posicion_siguiente.y);
                }
                else
                {
                    indice = 0;
                    this.transform.position = posicion_actual;
                    posicion_siguiente = ruta.transform.GetChild(0).position;
                }
            }
        //}

        

    }

    /*public bool Esta_viva
    {
        get
        {
            return esta_viva;
        }

        set
        {
            esta_viva = value;
        }
    }*/
    
    /*if (tiempo > 0.5)
      {
        if (indice < ruta.transform.childCount)
        {
            Debug.Log(ruta.transform.GetChild(indice).transform.position.x + " " + ruta.transform.GetChild(indice).transform.position.y);
            this.transform.position = new Vector3(ruta.transform.GetChild(indice).transform.position.x, ruta.transform.GetChild(indice).transform.position.y, this.transform.position.z);
            indice++;
        }
        tiempo = 0;
      }
      else
        {
        tiempo += Time.deltaTime;
        }
      }

      public float[] obtenerRuta()
     {
    return new float[] { 0.0f };
     } */

}
