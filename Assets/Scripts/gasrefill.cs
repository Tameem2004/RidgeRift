using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasrefill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        VehicleController.instance.gas= 1f;
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
