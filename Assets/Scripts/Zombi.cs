using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator animar;
    private SpriteRenderer render;

    public int Vida1 = 5;

    public static int daños;
    public int refeDaño = 1;


    void Start()
    {
        daños = refeDaño;

        body = GetComponent<Rigidbody2D>();
        animar = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("disparo1"))
        {
            Vida1 -= Disparar.daño1;
            Debug.Log("Tengo Menos Vida");
            if (Vida1 <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Muerto");
            }

        }
    }

}
