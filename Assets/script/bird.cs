using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public GameObject gameOver;
    public Text score;
    int h = 0;
    public AudioSource audioSource;
    public AudioSource wing;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        score = GameObject.Find("score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
            wing.enabled = true;
            rb.AddForce(Vector2.up * speed);
        }else if (Input.GetMouseButtonUp(0))
        {
            wing.enabled = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "grounded")
        {
            Time.timeScale = 0;
            Destroy(wing);
            gameOver.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "flag")
        {
            h += 1;
            score.text = h.ToString();
            audioSource.enabled = true;
        }
    }
}
