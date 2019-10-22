using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{
    public Vector3 alvo = new Vector3(5, 0, 4);
    public float velocidade = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(alvo.normalized * velocidade* Time.deltaTime);
        
    }
}
