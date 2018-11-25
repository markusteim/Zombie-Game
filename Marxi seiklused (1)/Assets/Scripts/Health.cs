using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public GameObject playerr;
    public int startingHealth = 100;
    public int currentHealth;
    public GameObject capsule;
    public void Start()
    {
        currentHealth = startingHealth;
    }

    public void Update()
    {
        if (currentHealth <= 0)
        {
            Debug.Log("YOU DIED");
            Destroy(playerr);

        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Death"))
        {
            currentHealth = 0;
            capsule.SetActive(false);
        }

    }

}

