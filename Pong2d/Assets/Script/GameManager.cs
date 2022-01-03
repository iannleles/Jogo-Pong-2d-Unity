using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int pontuacaoDoJogador1;

    public int pontuacaoDoJogador2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AumentarPontuacaoDoJogador1()
    {
        pontuacaoDoJogador1 += 1;
    }    
    public void AumentarPontuacaoDoJogador2()
    {
        pontuacaoDoJogador2 += 1;
    }
}
