using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamondscript : MonoBehaviour
{

    public float rotationSpeed = 200;

    public SpriteRenderer rend;
    public Color newcolor;
    public Transform other;
    public int speed = 3;


    // Use this for initialization
    void Start()
    {
        rend.color = newcolor;
        rend.color = new Color(1f, 0.5f, 0.3f);
        //other.position = new Vector3(3, 2, other.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        }
     
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(5 * Time.deltaTime, 0, 0);
        }
       
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-3 * Time.deltaTime, 0, 0);
        }


        //transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        //transform.Translate(1 * Time.deltaTime, 0, 0);
    }
}
