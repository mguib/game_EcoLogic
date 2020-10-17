using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enimy_2 : MonoBehaviour
{
    public float speed;
    public float moveTime;

    private bool dirRigth = true;
    private float timer;


    // Update is called once per frame
    void Update()
    {
        if (dirRigth)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;

        if (timer >= moveTime)
        {
            dirRigth = !dirRigth;
            timer = 0;
        }
    }
}
