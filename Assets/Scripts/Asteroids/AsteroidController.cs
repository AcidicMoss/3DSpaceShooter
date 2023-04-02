using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{

    public  float moveSpeed = 20f;
    private Rigidbody rb;
    private Vector3 randomRotation;
    

    public float distanceThreshold = 500f; // The maximum distance the asteroid can be from the player before being destroyed

    private Transform player; // Reference to the player's transform
    private bool isDestroyed = false; // Flag to keep track of whether the asteroid has been destroyed

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        randomRotation = new Vector3(Random.Range(0f, 100f), Random.Range(0f, 100f), Random.Range(0f, 100f));
        //player = GameObject.FindGameObjectWithTag("Player_Ship").transform; // Find the player object by tag
        
    }

    // Update is called once per frame
    void Update()
    {   
    //    if (!isDestroyed)
    //     {
    //         float distanceToPlayer = Vector3.Distance(transform.position, player.position); // Calculate the distance to the player
    //         if (distanceToPlayer > distanceThreshold) // Check if the distance exceeds the threshold
    //         {
    //             Destroy(gameObject); // Destroy the asteroid
    //             isDestroyed = true; // Set the flag to true to prevent multiple destroy calls
    //         }
    //     }

        Vector3 movementVector = new Vector3(0f,0f, -moveSpeed * Time.deltaTime);
        rb.velocity = movementVector;

        transform.Rotate(randomRotation * Time.deltaTime);
    }
}
