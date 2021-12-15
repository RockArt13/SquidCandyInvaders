using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candies : MonoBehaviour
{

    float timer = 0;
    float timerToMove = 0.5f;
    float numOfMovements = 0;
    float speed = 0.25f;

    public GameObject candy; // candies are our enemies
    public GameObject candyProjectile;
    public GameObject candyProjectileClone;

    public AudioSource audioTest;
    public AudioClip destroySound;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.playGame)
        {
            // The mechanic for the movement
            if (numOfMovements == 18) // ~ 18 is the approximate number of frames to the edge of the screen.
            {
                // so if the enemy reaches it, it should
                                                        // go down 
                transform.Translate(new Vector3(0, -1, 0));
                numOfMovements = -1;
                                                        // and return back;
                speed = -speed;
                timer = 0;
            }

            // The movement in action
            timer += Time.deltaTime;
            if (timer > timerToMove && numOfMovements != 18)
            {
                transform.Translate(new Vector3(speed, 0, 0));
                timer = 0;
                numOfMovements++;
            }

            // Hey candies, don't forget to fire on the Doll :) 
            candyFiresOnTheDoll();
        }
    }


    // Each candy can fire with "little candies" on the Doll
    void candyFiresOnTheDoll()
    {
        // In fact, the second argument of Range() is directly dependent variable to the difficulty of the game.
        if (Random.Range(0f, 500f) < 1)
        {
            // Clones the object original and returns the clone.
            candyProjectileClone = Instantiate(candyProjectile, new Vector3(candy.transform.position.x, candy.transform.position.y + 0.4f, 0), candy.transform.rotation) as GameObject;

        }
    }


    // Looks a simple function, yes? Huh )
    // This is just for playing a destroySound.wav
    // And I spent over 4 hours to understand how Unity works with sounds
    // And why I should call the sound from Crandies.cs
    // instead of doing it in HerProjectile.cs

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Proj")
        {
            audioTest.PlayOneShot(destroySound); // Enemy meets a projectile
            Destroy(collision.gameObject);      // and "booboom"!
        }  
    }
}

    
   
