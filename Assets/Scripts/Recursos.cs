using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recursos : MonoBehaviour
{
    public int puntos;
    public Text puntaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntaje.text = puntos.ToString();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Recursos"))
        {
            Destroy(other.gameObject);
            puntos ++;
        }
    }
}

