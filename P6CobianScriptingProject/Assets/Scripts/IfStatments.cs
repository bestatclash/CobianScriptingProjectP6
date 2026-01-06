using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatments : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
       
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TempertureTest();
        )

            coffeeTemperture -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    // Update is called once per frame
    void Update()
    {
        
    }
}
