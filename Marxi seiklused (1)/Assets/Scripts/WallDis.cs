using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDis : MonoBehaviour {
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    // Use this for initialization
    void Start() {
        wall1.GetComponent<MeshRenderer>().enabled = false;
        wall2.GetComponent<MeshRenderer>().enabled = false;
        wall3.GetComponent<MeshRenderer>().enabled = false;
        wall4.GetComponent<MeshRenderer>().enabled = false;


    }
 }