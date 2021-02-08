using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo : MonoBehaviour
{
    public GameObject semafororojo;
    public GameObject semaforoverde;
    public GameObject semaforoamarillo;
    
    public bool Semaforoverde;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrafficLuz1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SemaforoRojo()
    {
        semaforoverde.SetActive(false);
        semaforoamarillo.SetActive(false);
        semafororojo.SetActive(true);
        Semaforoverde = false;
    }    
    void SemaforoVerde()
    {
        semaforoverde.SetActive(true);
        semaforoamarillo.SetActive(false);
        semafororojo.SetActive(false);
        Semaforoverde = true;
    }
    void SemaforoAmarillo()
    {
        semaforoverde.SetActive(false);
        semaforoamarillo.SetActive(true);
        semafororojo.SetActive(false);
        Semaforoverde = true;
    }
    IEnumerator TrafficLuz1()
    {
        while (true)
        {
            SemaforoRojo(); 
            yield return new WaitForSeconds(5);           
            SemaforoVerde();
            yield return new WaitForSeconds(3);
            SemaforoAmarillo();
            yield return new WaitForSeconds(2);
        }
    }
}
