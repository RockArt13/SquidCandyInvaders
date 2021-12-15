using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerProjectile : MonoBehaviour
{
    public GameObject herProjectile;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // hitting the enemy
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);  // destroying a candy
            GameManager.candiesCount--;     // decrementing a candies' amount 
            Destroy(herProjectile);         // destroyong a projectile
            GameManager.playGame = true;    // game is ON
        }

        // not hitting the enemy
        if (collision.gameObject.tag == "Edge")
        {
            Destroy(herProjectile);         // destroyong a projectile
        }
    }
}


