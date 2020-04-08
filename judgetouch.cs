using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class judgetouch : MonoBehaviour
{
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        ui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            print("唉你注意点！你撞到我了！");
            ui.SetActive(true);
        }
       
    }
    private void OnCollisionExit(Collision collision)
    {
        print("谢天谢地你走了！");
        ui.SetActive(false);
    }
}
