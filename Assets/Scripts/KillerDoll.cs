using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerDoll : MonoBehaviour
{

    public GameObject doll;
    public GameObject herProjectile;
    public GameObject herProjectileClone;

    public AudioSource audioShoot;

    private Camera mainCamera;

    private float rightScreenEdge;
    private float leftScreenEdge;
    private float bottomScreenEdge;
    private float upScreenEdge;


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

        // Detecting all 4 edges of the screen
        rightScreenEdge = mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth, 0,0)).x;
        leftScreenEdge = mainCamera.ScreenToWorldPoint(Vector3.zero).x;
        bottomScreenEdge = mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelHeight, 0, 0)).y;
        bottomScreenEdge = mainCamera.ScreenToWorldPoint(Vector3.zero).y;

        // For shooting sound
        audioShoot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.lives>0)
        { 
        movement();
        fireProjectile();
        }
    }

    // Moving our Doll
    void movement()
    {

        Vector3 currentPos = gameObject.transform.position;

        // →
        if ((currentPos.x <= rightScreenEdge) && (Input.GetKey(KeyCode.RightArrow)))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }

        // ←
        if ((currentPos.x >= leftScreenEdge) && (Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }

        // ↑
        if ((currentPos.y <= upScreenEdge) && (Input.GetKey(KeyCode.UpArrow)))
        {
            transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
        }

        // ↓
        if ((currentPos.y >= bottomScreenEdge) &&  (Input.GetKey(KeyCode.DownArrow)))
        {
            transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
        }

    }

    // Shooting Projectile
    void fireProjectile()
    {
        // The Doll holds a "Single-Shot" gun
        if (Input.GetKeyDown(KeyCode.Space) && herProjectileClone == null)
        {
            // Clones the object original and returns the clone.
            herProjectileClone = Instantiate(herProjectile, new Vector3(doll.transform.position.x, doll.transform.position.y + 0.6f, 0), doll.transform.rotation) as GameObject;
            audioShoot.Play();
        }
    }

}



