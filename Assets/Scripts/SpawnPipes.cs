using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    // Pegar o Objeto Pipe da Cena (O objeto pai Cano)
    public GameObject pipe;
    // variavel responsavel pela altura que os canos vão vir
    private float height = 2f;
    // Tempo que os canos vao vir
    private float maxTime = 3f;
    //Contador de tempo
    private float timer = 0f;
    void Start()
    {
        // Uma nova variavel chamada newPipe, ela vai instanciar objetos do tipo Pipe
        GameObject newPipe = Instantiate(pipe);
        // A posicao do newPipe vai ser sorteada na posicao Y, por isso o Random.Range esta nele
        // É importante ressaltar que vai ser sorteado um valor entre height e -height
        // Poderia ser colocado dois valores como por exemplo (-2,3) ou (100,1000)
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);
    }

    // Update is called once per frame
    void Update()
    {   // Logica do If: Se o tempo for maior que o tempoMaximo
        // No caso tempo for maior que 3, ele repete a instancia da Start()
        if(timer > maxTime){
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);

            // Para não consumir muita memoria, os pipes que ja passaram sao destruidos logo em seguida
            // E o tempo é zerado
            Destroy(newPipe, 7f);
            timer = 0;
        }

        // Um contador de tempo, ele irá contar cada segundo;
        timer = timer + Time.deltaTime;
    }
}
