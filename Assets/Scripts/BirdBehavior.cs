using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehavior : MonoBehaviour
{
    //Velocidade do Passaro
    private float speed = 3f;
    //Adicionando o RB2D do GameObject
    private Rigidbody2D rig;

    public GameObject gameOver;

    
    void Start()
    {
        // Vamos buscar o Rigidbody2D do GameObjetc
        rig = GetComponent<Rigidbody2D>();
        
        
        // Extra: Diminui a força da gravidade para 0.6
        // Isso dá a impressão que o passarinho está mais leve
        rig.gravityScale = 0.6f;
        
    }

    
    void Update()
    {
        // Se o botão esquerdo do mouse for pressionado
        // Adicionamos no Rigidbody um Vector2 * velocidade
        if(Input.GetMouseButtonDown(0)){
            rig.velocity = Vector2.up * speed;
        }
        
    }


    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Pipe"){
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
        
    }


}
