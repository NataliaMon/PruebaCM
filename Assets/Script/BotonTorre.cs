using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonTorre : MonoBehaviour {

    public GameObject torre;

    private void OnMouseDown()
    {
        Instantiate(torre, transform.parent.position, Quaternion.identity);
        Destroy(transform.parent.gameObject);


    }




}
