using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float yForce;
    public float xForce;
    public float xDirection;
    private Rigidbody2D enemyRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpforce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpforce);
        }
        if (collision.gameObject.tag == "Player")
        {
            Vector2 jumpforce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpforce);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Vector2 jumpforce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpforce);


            if (collision.gameObject.transform.position.x > this.gameObject.transform.position.x)
            {
                xDirection = -1;
                enemyRigidBody.AddForce(Vector2.left * xForce);
            }
            else if (collision.gameObject.transform.position.x < this.gameObject.transform.position.x)
            {
                xDirection = 1;
                enemyRigidBody.AddForce(Vector2.right * xForce);
            }
        } 
    }

    private void FixedUpdate()
    {
        if (transform.position.x <= -8)
        {
            xDirection = 1;
            enemyRigidBody.AddForce(Vector2.right * xForce);
        }

        if (transform.position.x >= 8)
        {
            xDirection = -1;
            enemyRigidBody.AddForce(Vector2.left * xForce);
        }

    }
}
