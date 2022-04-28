using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mega : MonoBehaviour
{
    public GameObject Bomba1;
    public GameObject Bomba2;
    public GameObject Bomba3;

    private Rigidbody2D body;
    private Animator animar;
    private SpriteRenderer render;

    private const int normal = 0;
    private const int correr = 1;
    private const int saltoo = 2;
    private const int correDispara = 3;

    private float Tiempo = 0f;


    void Start()
    {

        body = GetComponent<Rigidbody2D>();
        animar = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        body.velocity = new Vector2(0, body.velocity.y);
        changeAnimation(normal);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            body.velocity = new Vector2(10, body.velocity.y);
            render.flipX = false;
            changeAnimation(correr);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.velocity = new Vector2(-10, body.velocity.y);
            render.flipX = true;
            changeAnimation(correr);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, 8);
            changeAnimation(saltoo);
        }

        if (Input.GetKeyUp(KeyCode.X) && Input.GetKey(KeyCode.RightArrow))
        {
            var x = this.transform.position.x + 1f;
            var y = this.transform.position.y;
            var Balas1 = Instantiate(Bomba1, new Vector2(x, y), Quaternion.identity) as GameObject;
            changeAnimation(correDispara);
        }

        if (Input.GetKeyUp(KeyCode.C) && Input.GetKey(KeyCode.RightArrow))
        {
            var x = this.transform.position.x + 1f;
            var y = this.transform.position.y;
            var Balas2 = Instantiate(Bomba2, new Vector2(x, y), Quaternion.identity) as GameObject;
            changeAnimation(correDispara);
        }

        if (Input.GetKeyUp(KeyCode.V) && Input.GetKey(KeyCode.RightArrow))
        {
            var x = this.transform.position.x + 1f;
            var y = this.transform.position.y;
            var Balas3 = Instantiate(Bomba3, new Vector2(x, y), Quaternion.identity) as GameObject;
            changeAnimation(correDispara);
        }

    }

    private void changeAnimation(int animation)
    {
        animar.SetInteger("Estado", animation);
    }

}
