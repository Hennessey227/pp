using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public float Speed = 150f;
    public float timeValue = 4;
    

    void Start()
    {
        
    }

  

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * Speed;
        //if (timeValue > 0)
        //{
            //timeValue -= Time.deltaTime;
        //}
        //else
        //{
           // if (name == "Bullet")
               // Destroy(Instantiate(gameObject, transform.position, transform.rotation), 2f);
        //}


        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }


}
