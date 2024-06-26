using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : PlayerController //Inheritance
{
    private Animator playerAnim;

    private void Start()
    {
        playerAnim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerAnim.SetBool("Bark_b", true);
        }
    }
}
