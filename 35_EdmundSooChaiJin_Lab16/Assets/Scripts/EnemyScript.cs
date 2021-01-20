using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public GameObject scoreSystem;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreSystem = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            score++;
            Destroy(gameObject);
            Destroy(collision.gameObject);

            scoreSystem.GetComponent<Text>().text = "Score: " + score.ToString();
        }
    }
}
