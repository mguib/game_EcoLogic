using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lata")
        {
            //SceneManager.LoadScene(levelName);
            Destroy(gameObject);
        }
    }
}
