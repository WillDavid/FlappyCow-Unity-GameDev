using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLamina : MonoBehaviour
{
 
    public GameObject lamina;
    
    private float height = 3f;
    // Tempo que os canos vao vir
    private float maxTime = 2f;
    //Contador de tempo
    private float timer = 0f;
    void Start()
    {
        GameObject newlamina = Instantiate(lamina);
        // A posicao do newPipe vai ser sorteada na posicao Y, por isso o Random.Range esta nele
        // É importante ressaltar que vai ser sorteado um valor entre height e -height
        // Poderia ser colocado dois valores como por exemplo (-2,3) ou (100,1000)
        newlamina.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);
    }

    
    void Update()
    {   // Logica do If: Se o tempo for maior que o tempoMaximo
        // No caso tempo for maior que 3, ele repete a instancia da Start()
        if(timer > maxTime){
            GameObject newlamina = Instantiate(lamina);
            newlamina.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);

            // Para não consumir muita memoria, os pipes que ja passaram sao destruidos logo em seguida
            // E o tempo é zerado
            Destroy(newlamina, 15f);
            timer = 0;
        }

        // Um contador de tempo, ele irá contar cada segundo;
        timer = timer + Time.deltaTime;
    }
}
