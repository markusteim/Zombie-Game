using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour {

    public GameObject coin;
    public int coin1 = 40;

    public void Start()
    {
        coin.SetActive(true);
    } 

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coin.SetActive(false);
            coin1 += 20;
            Debug.Log("You gained 20 coins");
        }
    }
}
