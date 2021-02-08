using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeep3 : MonoBehaviour
{
    public float Speed = 2f;
    public GameObject EstadoSemaforo;
    public bool Control1;
    // Start is called before the first frame update
    void Start()
    {
        EstadoSemaforo = GameObject.Find("Semaforo3");
        Control1 = false;
        transform.position = new Vector2(-0.36f, 5.69f);
        transform.Rotate(0, 0, 180);
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
        if (EstadoSemaforo.GetComponent<Semaforo3>().Semaforo3verde || Control1)
        {
            transform.Translate(new Vector2(0, 1f) * Speed * Time.deltaTime);
        }


    }
}
