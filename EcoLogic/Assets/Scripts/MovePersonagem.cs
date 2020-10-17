using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePersonagem : MonoBehaviour
{
    private Rigidbody2D rig;
    public float vel;
    public static Vector2 direcao;    
    public string dir;
    public Animator animator;
    public BoxCollider2D boxCollider2D;
    private int heat;
    public GameObject defeat;
    public GameObject defeat_text;
    public List<Sprite> huds;
    public SpriteRenderer coracoes;
    private int tries;
    public Button next_level;
    

    private bool colliding;

    // Start is called before the first frame update
    void Start()
    {
        next_level.interactable = true;
        tries=0;
        //vel = 7f;
        defeat.SetActive(false);
        defeat_text.SetActive(false);
        direcao = Vector2.zero;
        rig = GetComponent<Rigidbody2D>();
        heat = 3;

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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            heat--;
            tries++;
            coracoes.sprite = huds[tries];
            Debug.Log("morrendo " + heat);
            if (heat == 0)
            {
                Destroy(gameObject);
                defeat.SetActive(true);
                defeat_text.SetActive(true);
                next_level.interactable = false;
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
