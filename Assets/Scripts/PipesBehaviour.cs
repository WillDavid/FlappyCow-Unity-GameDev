using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesBehaviour : MonoBehaviour
{
    // Velocidade dos canos
    private float speed = 2f;
    void Update()
    {

        // Fazer com que o cano sempre vá para a esquerda
        // Estamos modificando diretamente o transform do objeto
        // Fazendo com que ele receba um impulso Vector3.left * velocidade na direção esquerda
        transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
    }
}
