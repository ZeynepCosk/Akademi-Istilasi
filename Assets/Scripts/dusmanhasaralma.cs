using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class düsmanhasaralma : MonoBehaviour
{
    public static float dusmansayısı = 1;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "atestopu")
        {
            dusmansayısı--;
            gameObject.SetActive(false);
        }
    }
}
