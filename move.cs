using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //speed = 1.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))

        {

        this.gameObject.transform.Translate(Vector3.forward*Time.deltaTime*speed);

        }

        if(Input.GetKey(KeyCode.S))

        {

        this.gameObject.transform.Translate(Vector3.back*Time.deltaTime*speed);

        }

        if(Input.GetKey(KeyCode.A))

        {

        this.gameObject.transform.Translate(Vector3.left*Time.deltaTime*speed);

        }

        if(Input.GetKey(KeyCode.D))

        {

        this.gameObject.transform.Translate(Vector3.right*Time.deltaTime*speed);

        }
        if(Input.GetKey(KeyCode.Space))

        {

        this.gameObject.transform.Translate(Vector3.up*Time.deltaTime*speed);

        }
        if (Input.GetKey(KeyCode.B))

        {

            this.gameObject.GetComponent<Renderer>().material.color = new Color(255f, 255f, 255f);

        }
        if (Input.GetKey(KeyCode.K))

        {

            this.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f);
            this.gameObject.GetComponent<Rigidbody>().mass = 10f;

        }
    }
   
}
