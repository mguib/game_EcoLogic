using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{

    private MovePersonagem move;

    private void Awake()
    {
        move = GameObject.Find ("Player").GetComponent<MovePersonagem>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Inimigo"))
        {
            if (!move.invunerable)
            {
                move.DamagePlayer();
            }
        }
    }
}
