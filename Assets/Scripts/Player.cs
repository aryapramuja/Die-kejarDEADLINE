using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float thrust;
    private Rigidbody2D rb2D;
    private bool isJump;

    // Start is called before the first frame update
    void Start()
    {
        isJump = false;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isJump = false;
        }
    }

    void Update()
    {
        if (transform.position.x <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJump) {
            rb2D.AddForce(new Vector3(0, thrust, 0), ForceMode2D.Impulse);
            isJump = true;
        }
    }
}
