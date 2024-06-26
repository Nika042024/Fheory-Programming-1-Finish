using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Chick : PlayerController //Inheritance
{
    private float m_maxHeight = 4.0f; //инкапсуляция - надо не допустить, чтобы слишком
    //высоко прыгал цыпленок
    public float maxHeight //общедоступна, чтобы можно было использовать
        //в другом классе (Jump)
    {
        get { return m_maxHeight; }
        set 
        {
            if (value > 5.0f)
            {
                Debug.LogError("You can't set a height value >5!");
            }
            else
            {
                m_maxHeight = value;
            }
        }
    }
    public override void Jump() //Polymorphism 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * maxHeight, ForceMode.Impulse);
        }

    }

}
