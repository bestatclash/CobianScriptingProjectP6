using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (input.GetKeyDown(KeyCode.R))
      }
         GetComponint<Renderer>().material.color = Color.red;
      }
      if (Input.GetKeyDown(KeyCode.G))
      {
         GetComponent<Renderer>().material.color = Color.green;
      }
      if (input.GetKeyDown(KeyCode.B))
      {
         GetComponent<Renderer>().material.color = Color.blue;
      }
   }
}



     