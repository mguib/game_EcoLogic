using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enimy_1 : MonoBehaviour
{
    public float speed;
    public float moveTime;

    private bool dirRigth = true;
    private float timer;

    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        if (dirRigth)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            animator.SetBool("Direita",true);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            animator.SetBool("Direita",false);
        }

        timer += Time.deltaTime;

        if (timer >= moveTime)
        {
            dirRigth = !dirRigth;
            timer = 0;
        }
    }
}
