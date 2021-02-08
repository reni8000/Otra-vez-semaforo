using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner4 : MonoBehaviour
{
   
    public GameObject Jeep4;
    public Semaforo4 semaforo4;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("GenerarCarro4", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void GenerarCarro4()
    {
        if (semaforo4.Semaforo4verde)
        {
            Instantiate(Jeep4, transform.position, Quaternion.identity);
        }
            
        

        //if (semaforo4.Semaforo4verde)
    }
}

