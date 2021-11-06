using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int score;
    public GameObject ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ScoreText.GetComponent<Text>().text = " My score:" + score;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.tag == "Coin")
        {
            score = score + 1;
            ScoreText.GetComponent<Text>().text = " My score:" + score;
            Destroy(collision.gameObject);
        }

      

    }
}
