using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    private float moveInput;
    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatisground;

    private int extrajumps;
    public int extrajumpvalue;

    public ParticleSystem blue;


    void Start(){
        extrajumps = extrajumpvalue;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatisground);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(facingRight == false && moveInput > 0){
            flip();
        } else if(facingRight == true && moveInput < 0){
            flip();
        }
    }

    void Update(){
        if(isGrounded == true){
            extrajumps = extrajumpvalue;
        }
        if(Input.GetKeyDown(KeyCode.Space) && extrajumps > 0){
            rb.velocity = Vector2.up * jumpforce;
            extrajumps--;

        } else if (Input.GetKeyDown(KeyCode.Space) && extrajumps == 0 && isGrounded == true){
            rb.velocity = Vector2.up * jumpforce;
        }
    }

    void flip(){
        createblue();
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x*=-1;
        transform.localScale = Scaler;
    }

    void createblue(){
        blue.Play();
    }

}
