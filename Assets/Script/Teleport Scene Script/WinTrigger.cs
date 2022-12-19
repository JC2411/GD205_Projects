using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject youWinText;
    // Start is called before the first frame update
    void Start()
    {
      youWinText.SetActive(false);  
    }

    // Update is called once per frame
      void OnTriggerEnter(Collider other)
    {if (other.gameObject.tag == "Sphere Player")
        { youWinText.SetActive(true); }
    }
}
