using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;// Float for the speed //public so it can be changed in the inspector
    public float jumpforce;// Float for the Jumpforce //public so it can be changed in the inspector
    private float moveInput;//MoveInput
    private Rigidbody2D rb;//Ridibody
    private bool facingRight = true;// player flip animation
    private bool isGrounded;//bool for isgrounded check
    public Transform groundCheck;//ground gameobject check
    public float checkRadius;//Float for Ground Radius check //public so it can be changed in the inspector
    public LayerMask whatisground;//Check what the ground is
    private int extrajumps;// int for extajumps
    public int extrajumpvalue;//how many extrajumps is the player alowed public so it can be changed in the inspector
    public ParticleSystem blue;// Player particle system
    public AudioClip JumpSound;//PlayerJump sound effect
    void Start() // Start is called before the first frame update
    {
        extrajumps = extrajumpvalue;// Extra jump equals extrajumpvalue
        rb = GetComponent<Rigidbody2D>();//getRigidibody component
    }
    void FixedUpdate(){
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatisground);//Isgrounded game object at the groundcheckpositon and the radius set by checkradius
        moveInput = Input.GetAxis("Horizontal");//Move Charcter left and right
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);//Move Charcter left and right at the speed set in inspector
        if(facingRight == false && moveInput > 0)//IF the moveinput is greater than 0 and faceright is false 
        {
            flip();// Run flip function CODE BELOW
        } 
        else if(facingRight == true && moveInput < 0)//IF the moveinput is less than 0 and faceright is true 
        {
            flip();// Run flip function CODE BELOW
        }
    }
    void Update()//Constantly running
    {
        if(isGrounded == true)// Checking if the play is on the ground
        {
            extrajumps = extrajumpvalue;//extrajumps is equal to the extrajumpvalue set in inspector
        }
        if(Input.GetKeyDown(KeyCode.Space) && extrajumps > 0)// if space is pressed and extra jump is above 0
        {
            doublejump();//Run double jump code

        } else if (Input.GetKeyDown(KeyCode.Space) && extrajumps == 0 && isGrounded == true)// if space is pressed and extra jump is equal 0
        {
            Singlejump();//Run Single jump code
        }
        if(Input.GetKeyDown(KeyCode.W) && extrajumps > 0)// if W is pressed and extra jump is above 0
        {
           doublejump();//Run double jump code

        } else if (Input.GetKeyDown(KeyCode.W) && extrajumps == 0 && isGrounded == true)// if W is pressed and extra jump is equal 0
        {
            Singlejump();//Run Single jump code
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && extrajumps > 0)// if Uparrow is pressed and extra jump is above 0
        {
            doublejump();//Run double jump code
        } else if (Input.GetKeyDown(KeyCode.UpArrow) && extrajumps == 0 && isGrounded == true)// if UpArrow is pressed and extra jump is equal 0
        {
            Singlejump();//Run Single jump code
        }
    }
    void flip()
    {
        createblue();//Whencharcter flips run Createblue function
        facingRight = !facingRight;// Faceright is equal to not facing right
        Vector3 Scaler = transform.localScale;// Using Vector 3 struct to flip the charcter 
        Scaler.x*=-1;//Fliping the charcter by all 3 postion by 1
        transform.localScale = Scaler;
    }
    void createblue()
    {//Blue particle function
        blue.Play();//Play the particle 
    }

    void Singlejump()//Fuction to stop from writting out all code again
    {
        rb.velocity = Vector2.up * jumpforce;//Only single jump
        AudioSource.PlayClipAtPoint(JumpSound, transform.position);//play jumpsound at play jump location
    }
    void doublejump()//Fuction to stop from writting out all code again
    {
        rb.velocity = Vector2.up * jumpforce;//PLayer will jump as high as the jumpforce set in inspector
        extrajumps--;//takeaway extrajumps
        AudioSource.PlayClipAtPoint(JumpSound, transform.position);//play jumpsound at play jump location
    }
}
