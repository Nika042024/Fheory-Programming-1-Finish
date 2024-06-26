using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    private bool isJumping;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        isJumping = false;
    }
    void Update()
    {
        Jump(); //Abstraction
    }
    public virtual void Jump() //Polymorphism 
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            playerRb.AddForce(Vector3.up * 300, ForceMode.Impulse);
            isJumping = true;
        }
    }
    private void OnCollisionEnter(Collision collision) 
    {
        isJumping = false;
    }

}
