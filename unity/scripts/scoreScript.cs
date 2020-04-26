using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public static int puntos = -17;
    Text puntosText;
    void Start()
    {
        puntosText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (puntos == -17)
        {
            puntosText.text = "0";
        }
        else
        {
            puntosText.text = puntos.ToString();
        }

    }
}
