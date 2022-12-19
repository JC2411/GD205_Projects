using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BasicMovement : MonoBehaviour
{
    Vector3 startPos;
    public Transform[] Hazards; 
    public Transform theKey;
    public AudioClip impact;
    public bool hasKey;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        audioSource = GetComponent<AudioSource>();
        hasKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = startPos;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {

            transform.position += Vector3.forward * 1.5f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            transform.position += Vector3.back * 1.5f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {

            transform.position += Vector3.left * 1.5f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            transform.position += Vector3.right * 1.5f;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

            transform.position += Vector3.up * 1.5f;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

            transform.position += Vector3.down * 1.5f;
        }
     for(int i = 0;i < Hazards.Length; i++){
                if (transform.position == Hazards[i].position){
                    transform.position = startPos;
                    audioSource.PlayOneShot(impact, 0.7F);
                }
     }
     if (transform.position == theKey.position){
           theKey.gameObject.SetActive(false);
           hasKey = true;
       }
     }
 }
