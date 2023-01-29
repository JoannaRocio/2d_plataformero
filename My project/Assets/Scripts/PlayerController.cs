using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        //Forma de especificar posiciones delta X y delta Y
        //gameObject.GetComponent<Transform>().position = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            //Forma de mover el objeto
            //gameObject.transform.Translate(-1 * Time.deltaTime, 0,0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-100f * Time.deltaTime, 0));

            //Instrucción para que moving sea true al moverse
            gameObject.GetComponent<Animator>().SetBool("moving", true);

            //Instrucción para voltear horizontalmente el personaje y que mire hacia el otro lado
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(100f * Time.deltaTime, 0));

            gameObject.GetComponent<Animator>().SetBool("moving", true);

            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

        if (Input.GetKeyDown("up") && canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10f));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            canJump = true;
        }
    }
}
