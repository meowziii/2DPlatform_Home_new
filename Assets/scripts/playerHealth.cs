using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    public SpriteRenderer playerSr;
    public playerMovement PlayerMovement;

    public GameObject Cat;
    public Transform respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int amount)
    {
        health -= amount;
        if(health <=0)
        {
            playerSr.enabled = false;
            PlayerMovement.enabled = false;  
        }
    }


}
