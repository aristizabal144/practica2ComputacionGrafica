using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barraVida : MonoBehaviour
{
    public GameObject gameover;
    public GameObject personaje;
    public Image healt;
    public static float hp, maxHp = 15f;

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp / maxHp > 0)
        {
            hp -= Time.deltaTime;
            healt.transform.localScale = new Vector3(hp / maxHp, 1, 1);
        }
        else
        {
            personaje.SetActive(false);
            gameover.SetActive(true);
            
        }
        
    }
}
