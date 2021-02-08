using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public GameObject Jeep3;
    public Semaforo3 semaforo3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarCarro3", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void GenerarCarro3()
    {
        if (semaforo3.Semaforo3verde)
        {
            Instantiate(Jeep3, transform.position, Quaternion.identity);
        }

    }
}