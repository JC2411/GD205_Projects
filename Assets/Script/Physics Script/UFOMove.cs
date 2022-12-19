using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UFOMove : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    private int count;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetCountText();
        winTextObject.SetActive(false);
    }

    // Update is called once per frame

    void Update()
    {
        Movement();
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
        if (count >= 5)
            winTextObject.SetActive(true);
    }


    void Movement()
    {
        moveSpeed = 10f;
        if (Input.GetKey(KeyCode.W)){
            rb.AddForce(Vector3.forward);
        } 
        if (Input.GetKey(KeyCode.S)){
            rb.AddForce(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(Vector3.right);
        }
        if (Input.GetKey(KeyCode.Q)){
            rb.AddForce(Vector3.up);
        }
        if (Input.GetKey(KeyCode.E)){
            rb.AddForce(Vector3.down);
        }
        if (Input.GetKey(KeyCode.F)){
             moveSpeed = 5f;  
            rb.velocity = new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.R)){
             moveSpeed = 0f;  
            rb.velocity = new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        { 
            other.gameObject.SetActive(false);
            count = count+1;
            transform.localScale += new Vector3(1, 1, 1);
            SetCountText();
        }
        
    }
}
