using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class Jeep : MonoBehaviour
{   
    public float Speed = 2f;
    public GameObject EstadoSemaforo;
    public bool Control1;
    // Start is called before the first frame update
    void Start()
    {
        Control1 = false;
        EstadoSemaforo = GameObject.Find("Semaforo");
        transform.position = new Vector2(0.21f, -5.96f);
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroyer")
            Destroy(this.gameObject);
        {
            if (collision.tag == "Control1")
            {
                Control1 = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (EstadoSemaforo.GetComponent<Semaforo>().Semaforoverde || Control1)
        { 
            transform.Translate(new Vector2(0, 1f) * Speed * Time.deltaTime);
        }


    }
    

    
        
        
    
    
       
}
