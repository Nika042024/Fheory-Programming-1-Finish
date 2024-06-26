using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    private bool isJumping; //предотвращает повторные прыжки в воздухе

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        isJumping = false;
    }
    void Update()
    {
        Jump(); //Abstraction - выделение в отдельный метод, чтобы вызывать его в любое время
    }
    public virtual void Jump() //Polymorphism 
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            playerRb.AddForce(Vector3.up * 300, ForceMode.Impulse);
            isJumping = true;
        }
    }
    private void OnCollisionEnter(Collision collision) //метод отслеживания столкновений
    {
        isJumping = false;
    }

}
