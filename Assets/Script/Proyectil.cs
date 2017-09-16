using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour {

    public GameObject objetivo;
    public float velocidad = 1f;
    public float distanciaUmbral = 0.1f;

	// Update is called once per frame
	void Update () {
        //Si el objetivo ya no existe se destruye el proyectil
        if (objetivo == null)
        {
            Destroy(this.gameObject);
        }

        else
        {
            //Cambiar la posicion de este proyectil en dirección al enemigo con una velocidad
            transform.position += (objetivo.transform.position - this.transform.position).normalized * velocidad * Time.deltaTime;

            //Si la distancia entre el objetivo y este proyectil es menor que la distancia de umbral, se destruye el proyectil y le resta vida al objetivo
            if (Vector3.Distance(objetivo.transform.position, transform.position) < distanciaUmbral)
            {
                Destroy(this.gameObject);

                //Se resta 1 a la variable vida de la componente Unidad del gameobject enemigo
                objetivo.GetComponent<Unidad>().vida -= 1;
                
            }

        }
 	}
}
