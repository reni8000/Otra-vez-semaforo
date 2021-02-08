using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo4 : MonoBehaviour
{
    public GameObject semaforo4verde;
    public GameObject semaforo4amarillo;
    public GameObject semaforo4rojo;
    public bool Semaforo4verde;
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
        semaforo4verde.SetActive(true);
        semaforo4amarillo.SetActive(false);
        semaforo4rojo.SetActive(false);
        Semaforo4verde = true;
    }
    void SemaforoUnoTresAmarillo()
    {
        semaforo4verde.SetActive(false);
        semaforo4amarillo.SetActive(true);
        semaforo4rojo.SetActive(false);
        Semaforo4verde = true;
    }
    void SemaforoUnoTresRojo()
    {
        semaforo4verde.SetActive(false);
        semaforo4amarillo.SetActive(false);
        semaforo4rojo.SetActive(true);
        Semaforo4verde = false;
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
