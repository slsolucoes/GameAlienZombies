using UnityEngine;
using System.Collections;

public class ControlZombie : MonoBehaviour
{

    public float speed = 10.0f;



    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

    }
}
