using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform alvo;
    public float velocidade = 2.0f;
    public float precisao = 0.01f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcao = alvo.position - this.transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direcao), 1.5f * Time.deltaTime);
        Debug.DrawRay(this.transform.position, direcao, Color.red);
        if (direcao.magnitude > precisao)
        {
            this.transform.Translate(direcao.normalized * velocidade * Time.deltaTime, Space.World);
        }
    }
}
