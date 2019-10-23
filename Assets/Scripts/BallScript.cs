using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rib;
	public Transform BallPosition;
	public float speed = 5f;
	public GameManager GM;
	
	
    void Start()
    {
		Respawn();
        rib = GetComponent<Rigidbody2D> ();	
		rib.AddForce(Vector2.up * speed);
		
    }

    void Update()
    {
       		
    }
	public void Respawn()
	{
		if (GM.gameOver)
			{
				return;
			}
		
		transform.position = BallPosition.position;
		GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
		
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Bottom"))
		{
				GM.UpdateLives (-1);
		}
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.transform.CompareTag("Brick"))
		{
			Destroy (other.gameObject);
			GM.UpdateScore (+10);
			GM.UpdateBricks();
		}
	}
}
