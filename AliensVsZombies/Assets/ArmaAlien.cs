﻿using UnityEngine;
using System.Collections;

public class ArmaAlien : MonoBehaviour
{

    // Use this for initialization
    public Transform bala;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (dir != Vector3.zero)
        {
            transform.forward = Vector3.Normalize(dir);            
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(bala, transform.position, Quaternion.identity);
        }
    }
    void OnTriggerEnter (Collider outro)
    {
        if(outro.GetComponent<Collider>().tag == "Zombie")
        {
            outro.GetComponent<Collider>().gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}