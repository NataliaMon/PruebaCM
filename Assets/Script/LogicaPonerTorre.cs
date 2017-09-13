using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPonerTorre : MonoBehaviour {

    public GameObject botonTorrePiedra;
    public GameObject botonTorreLanza;

    void OnMouseDown()
    {
        botonTorrePiedra.SetActive(true);
        botonTorreLanza.SetActive(true);

    }
}


