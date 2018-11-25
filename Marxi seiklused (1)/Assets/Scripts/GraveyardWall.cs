using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveyardWall : MonoBehaviour
{
    public int key = 0;
    public GameObject key1;
    public GameObject door;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            key += 1;
            Debug.Log("You found the key and destroyed the big door!");
            key1.SetActive(false);
            door.SetActive(false);
        }
    }
}

