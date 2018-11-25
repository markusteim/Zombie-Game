using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDis2 : MonoBehaviour
{
    public GameObject wall1;
   
    // Use this for initialization
    void Start()
    {
        wall1.GetComponent<MeshRenderer>().enabled = false;
        

    }
}