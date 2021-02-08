using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo3 : MonoBehaviour
{
    public GameObject semaforo3rojo;
    public GameObject semaforo3verde;
    public GameObject semaforo3amarillo;

    public bool Semaforo3verde;
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
        semaforo3verde.SetActive(false);
        semaforo3amarillo.SetActive(false);
        semaforo3rojo.SetActive(true);
        Semaforo3verde = false;
    }
    void SemaforoVerde()
    {
        semaforo3verde.SetActive(true);
        semaforo3amarillo.SetActive(false);
        semaforo3rojo.SetActive(false);
        Semaforo3verde = true;
    }
    void SemaforoAmarillo()
    {
        semaforo3verde.SetActive(false);
        semaforo3amarillo.SetActive(true);
        semaforo3rojo.SetActive(false);
        Semaforo3verde = true;
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