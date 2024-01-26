using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehicleController : MonoBehaviour
{
    public static VehicleController instance;
    public Rigidbody2D Ftire;
    public Rigidbody2D Btire;
    public Rigidbody2D vehicle;
    public float speed;
    public float movement;
    public float gas =1f;
    public float gasConsumption=0.1f;
    public Image gasImage;
    // Start is called before the first frame update
    public void Awake ()
    {
        if(instance==null)
        {
            instance=this;
        }
    }
    void Start()
    {
        
    }
    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
        gasImage.fillAmount=gas;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(gas>0)
        {
            Ftire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            Btire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            vehicle.AddTorque(movement * speed * Time.fixedDeltaTime);
        }
        gas=gas-gasConsumption * Time.fixedDeltaTime * Mathf.Abs(movement);
    }
}
