using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyProjectile : MonoBehaviour
{
    public GameObject candyProjectile;
    Vector3 respawn = new Vector3(0, -6, 0); // Starting point for The Doll
    public AudioSource resetAudio;
    public AudioClip resSound;

   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // hitting the doll
        if (collision.gameObject.tag == "Player")
        { 
            collision.gameObject.transform.position = respawn;  // The Doll dies, respawns,
            Destroy(candyProjectile);                           // Projectile destroys
            GameManager.lives--;                                // The Doll loses one live
            resetAudio.PlayOneShot(resSound);                   // And that's not good!
            GameManager.playGame = false;                       // Pause the game, The Doll needs to take a breath
        }

        // not hitting the doll
        if (collision.gameObject.tag == "Edge")
        {
            Destroy(candyProjectile);
        }
    }
}
