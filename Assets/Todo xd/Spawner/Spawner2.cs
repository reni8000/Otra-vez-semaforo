using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject Jeep2;
    public Semaforo2 semaforo2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarCarro2", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void GenerarCarro2()
    {
        if (semaforo2.Semaforo2verde)
        {
            Instantiate(Jeep2, transform.position, Quaternion.identity);
        }
    }
}
