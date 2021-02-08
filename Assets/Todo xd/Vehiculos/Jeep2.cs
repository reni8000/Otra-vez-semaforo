using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeep2 : MonoBehaviour
{
    public float Speed = 2f;
    public GameObject EstadoSemaforo;
    public bool Control1;
    // Start is called before the first frame update
    void Start()
    {
        Control1 = false;
        EstadoSemaforo = GameObject.Find("Semaforo2");
        transform.position = new Vector2(6.48f, 0.29f);
        transform.Rotate(0, 0, 90, Space.Self);
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
        if (EstadoSemaforo.GetComponent<Semaforo2>().Semaforo2verde || Control1)
        {
            transform.Translate(new Vector2(0, 1f) * Speed * Time.deltaTime);
        }

    }
}
