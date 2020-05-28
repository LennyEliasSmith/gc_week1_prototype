using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class EnemyScript : MonoBehaviour
{


    

    public float _speed = 5f;
    public float zSpeed = 0.5f;
    // Update is called once per frame

    void Start()
    {
       
    }
    void Update()
    {
        Vector3 _movementVector = new Vector3(0, 0, zSpeed * _speed);
        transform.Translate(_movementVector);


        
    }




}
