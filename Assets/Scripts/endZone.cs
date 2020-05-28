using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endZone : MonoBehaviour
{
   public playerMovement player;
    // Update is called once per frame

   void Start()
    {
        player = FindObjectOfType<playerMovement>();
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Score up");
           
            Destroy(other.gameObject);
            player.score++;

        }
    }
}
