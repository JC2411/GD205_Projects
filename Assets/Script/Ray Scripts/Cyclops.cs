using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cyclops : MonoBehaviour
{

    public float explosionForce = 5f;
    public float upwardForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
       RaycastHit hit = new RaycastHit();

       if (Physics.Raycast( laser, out hit, 200000000f)){
          if (Input.GetMouseButton(0) && hit.rigidbody){
            hit.rigidbody.AddExplosionForce(explosionForce, hit.point, upwardForce);
        }
      }
    }
}
