using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public float velocidad = 2;
    
    private Rigidbody2D body;

    public static int da�o1;

    public int refeDa�o = 1;


    void Start()
    {
        da�o1 = refeDa�o;

        body = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 3);
    }

    void Update()
    {
        body.velocity = new Vector2(velocidad, body.velocity.y);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("zombie"))
        {
            Destroy(this.gameObject);
        }
    }
}
