using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    

    public void Lentiviris()
    {
        Time.timeScale = 0.5f;
    }

    public void Normaliviris()
    {
        Time.timeScale = 1;
    }

    public void Rapidiviris()
    {
        Time.timeScale = 3;
    }
}
    

