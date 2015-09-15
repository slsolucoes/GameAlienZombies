using UnityEngine;
using System.Collections;

public class ControlAlien : MonoBehaviour
{

    public float speed = 10.0f;    

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}
