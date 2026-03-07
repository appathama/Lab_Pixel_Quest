using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.RendererUtils;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    private SpriteRenderer sr;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sr.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sr.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sr.color = Color.blue;
        }
        {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        }
    }

    public int counter = 4;
    private Rigidbody2D rb;
    public int speed = 10;
    public string nextlevel = "Level_2";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    Debug.Log("Player Has Died");
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

 
}
