using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject Jeep;
    public Semaforo semaforo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarCarro", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenerarCarro()
    {
        if (semaforo.Semaforoverde) 
        {
            Instantiate(Jeep, transform.position, Quaternion.identity);
        }
            

    }
}
