using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    public float velocidadeDaBola;

    public Rigidbody2D oRigidyBody2d;

    public AudioSource somDaBola;

    public float direcaoAleatoriaX;

    public float direcaoAleatoriaY;

    // Start is called before the first frame update
    void Start()
    {
        MoverBola();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoverBola()
    {
        oRigidyBody2d.velocity = new Vector2(velocidadeDaBola, velocidadeDaBola);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        somDaBola.Play();
        if (oRigidyBody2d.velocity.x > 0 && oRigidyBody2d.velocity.y > 0)
        {
            oRigidyBody2d.velocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);
        }
        else
        {
            oRigidyBody2d.velocity += new Vector2(-direcaoAleatoriaX, -direcaoAleatoriaY);
        }

    }
}
