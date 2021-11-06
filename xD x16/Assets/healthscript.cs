using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthscript : MonoBehaviour
{

    public GameObject Health;  
    public GameObject SPAWNER;
    public GameObject WinText
    public int hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = 10;
            Health.GetComponent<Text>().text = "Health:" + hp;
    }

    // Update is called once per frame
    void Update()
    {
        Health.GetComponent<Text>().text = "Health:" + hp;
    }



    private void OnCollisionEnter(Collision collision)
    {
     if (collision.gameObject.tag == "dangerblock")

        {
            hp--;
        }
    }
}
