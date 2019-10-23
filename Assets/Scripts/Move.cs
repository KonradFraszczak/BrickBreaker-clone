using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Move : MonoBehaviour
{
   private Rigidbody2D rb;
   private float dirX;
   private float speed = 10f;
   public float RightEdge;
   public float LeftEdge;
   public GameManager GM;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
		if (GM.gameOver)
			{
				return;
			}
			
			dirX = CrossPlatformInputManager.GetAxis("Horizontal") * speed;
			rb.velocity = new Vector2(dirX, 0f);
			
			if (transform.position.x < LeftEdge){
				transform.position = new Vector2 (LeftEdge, transform.position.y);
			}
			if (transform.position.x > RightEdge){
				transform.position = new Vector2 (RightEdge, transform.position.y);
			}
			
    }
}
