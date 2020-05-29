using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    public Rigidbody rb;

    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoreText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        scoreText.text = score.ToString();
    }

    public void Movement()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        Vector3 moving = new Vector3(horizontalAxis * speed, 0, verticalAxis * speed);
        rb.AddForce(moving);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("U ded");
            SceneManager.LoadScene(2);

        }

    }
}
