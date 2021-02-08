using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo2 : MonoBehaviour
{
    public GameObject semaforo2verde;
    public GameObject semaforo2amarillo;
    public GameObject semaforo2rojo;
    public bool Semaforo2verde;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrafficLuz());
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SemaforoUnoTresVerde()
    {
        semaforo2verde.SetActive(true);
        semaforo2amarillo.SetActive(false);
        semaforo2rojo.SetActive(false);
        Semaforo2verde = true;
    }
    void SemaforoUnoTresAmarillo()
    {
        semaforo2verde.SetActive(false);
        semaforo2amarillo.SetActive(true);
        semaforo2rojo.SetActive(false);
        Semaforo2verde = true;
    }
    void SemaforoUnoTresRojo()
    {
        semaforo2verde.SetActive(false);
        semaforo2amarillo.SetActive(false);
        semaforo2rojo.SetActive(true);
        Semaforo2verde = false;
    }
    IEnumerator TrafficLuz()
    {
        while (true)
        {
            SemaforoUnoTresVerde();
            yield return new WaitForSeconds(3);
            SemaforoUnoTresAmarillo();
            yield return new WaitForSeconds(2);
            SemaforoUnoTresRojo();
            yield return new WaitForSeconds(5);
        }
    }

}

