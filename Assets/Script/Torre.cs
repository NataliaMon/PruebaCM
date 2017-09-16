using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour {

    public Proyectil proyectilprefab;
    public float cooldown = 1f;
    private float cooldownTimer = 0;
    private bool puededisparar = true;


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("unidad") && puededisparar)
        {
            Debug.DrawLine(transform.position, other.transform.position, Color.green);

            //Crear una nueva instancia (copia) del objeto proyectilprefab y meterla a la escena
            Proyectil nuevoProyectil = Instantiate(proyectilprefab, this.transform.position, Quaternion.identity); 

            //Asignar el gameObject del enemigo al proyectil
            nuevoProyectil.objetivo = other.gameObject;

            puededisparar = false;
           
        }

        
    }

    private void Update()
    {
        if (cooldownTimer >= cooldown)
        {
            puededisparar = true;
            cooldownTimer = 0;
        }

        cooldownTimer += Time.deltaTime;
    }
}
