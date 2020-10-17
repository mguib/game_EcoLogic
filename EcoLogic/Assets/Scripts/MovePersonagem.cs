using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersonagem : MonoBehaviour
{
    private Rigidbody2D rig;
    public float vel;
    public static Vector2 direcao;    
    public string dir;
    public Animator animator;
    public BoxCollider2D boxCollider2D;
    public int heat;
    public bool invunerable = false;


    private SpriteRenderer sprit;
    private bool colliding;

    // Start is called before the first frame update
    void Start()
    {
        //vel = 7f;
        direcao = Vector2.zero;
        rig = GetComponent<Rigidbody2D>();
        heat = 3;
        sprit = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        InputPersonagem();
        transform.Translate(direcao * vel * Time.deltaTime);

        /*if (direcao.x != 0 || direcao.y != 0)
        {
            Animacao(direcao);
        }
        else
        {
            anim.SetLayerWeight(1, 0);
        }*/

        if (Cima.pressionando)
        {
            direcao += Vector2.up;
            transform.Translate(new Vector2(0,vel * Time.deltaTime));
            animator.SetFloat("Idle",1f);
            
        }
        if (Baixo.pressionando)
        {
            direcao += Vector2.down;
            transform.Translate(new Vector2(0, -1 * vel * Time.deltaTime));
            animator.SetFloat("Idle",2f);
            
        }
        if (Direita.pressionando)
        {
            direcao += Vector2.right;
            transform.Translate(new Vector2(vel * Time.deltaTime, 0));
            animator.SetFloat("Idle",3f);
            
        }
        if (Esquerda.pressionando)
        {
            direcao += Vector2.left;
            transform.Translate(new Vector2( -1* vel * Time.deltaTime, 0));
            animator.SetFloat("Idle",4f);
            
        }

        animator.SetFloat("Horizontal",direcao.x);
        animator.SetFloat("Vertical",direcao.y);
        animator.SetFloat("Speed",direcao.sqrMagnitude);
    }
    

    void InputPersonagem()
    {
        direcao = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direcao += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direcao += Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direcao += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direcao += Vector2.right;
        }

    }

    IEnumerator Damage()
    {
        for (float i = 0f; i < 1f; i +=0.1f)
        {
            sprit.enabled = false;
            yield return new WaitForSeconds(0.1f);
            sprit.enabled = true;
            yield return new WaitForSeconds(0.1f);
        }
        invunerable = false;
    }
    public void DamagePlayer()
    {
        invunerable = true;
        heat--;
        StartCoroutine(Damage());
        if (heat < 1)
        {            
            Debug.Log("Morreu");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            heat--;
            Debug.Log("morrendo " + heat);
            if (heat == 0)
            {
                Destroy(gameObject);
            }

        }
    }


    /*void Animacao(Vector2 dir)
    {
        anim.SetLayerWeight(1, 1);

        anim.SetFloat("x", dir.x);
        anim.SetFloat("y", dir.y);
    }*/
}
