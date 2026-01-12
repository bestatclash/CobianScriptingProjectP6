

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VariableAndFunction : MonoBehaviour
{
    //create an innterger variable
    int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        //run the variiable through my function  
        myInt = MultiplyByTwo(myInt);
        //display the result in the console
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //creating my function
     int MultiplyByTwo(int number)
     { 
       //creat a results variable
        int result;
        result = number* 2;

        //return the result
        return result; 

     }


}