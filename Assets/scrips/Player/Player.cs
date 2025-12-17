using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Components
    [SerializeField] Rigidbody rb;
    [SerializeField] Animator ani;

    //Control Variables 
    [SerializeField] bool isGrounded;
    [SerializeField] Transform psitionGroundCheck;
    [SerializeField] Vector3 boxSize;
    [SerializeField] LayerMask groundLayer;   
    [SerializeField] float jumpForce;
    private int playerHealth;

    //class
    [SerializeField] Jump jumpClass;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpClass = new Jump();       
    }
    void Update()
    {
        // ani.SetBool("Jump", false);
        isGrounded = Physics.CheckBox(psitionGroundCheck.position,boxSize,Quaternion.identity,groundLayer);
        if(isGrounded)
        {
            ani.SetBool("Jump", false);
        }
    }
    public void Jump()
    {
       if (isGrounded)
       {
            jumpClass.JumpAction(rb, jumpForce, ani);
       }
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(psitionGroundCheck.position,boxSize);
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "EndGameZone")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
