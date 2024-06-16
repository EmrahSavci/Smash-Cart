using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour,ICollect
{
    public VehicleSO vehicleSO;

    Rigidbody rb;
    [SerializeField] float horizontal;
    [SerializeField] float vertical;

    [SerializeField] Transform frontLeftWheel;
    [SerializeField] Transform frontRightWheel;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            horizontal =joystick.Horizontal * vehicleSO.RotateSpeed*Time.deltaTime;
            vertical = joystick.Vertical * vehicleSO.RotateSpeed*Time.deltaTime;
            frontLeftWheel.transform.rotation = Quaternion.Euler(0, vertical, 0);
            frontRightWheel.transform.rotation = Quaternion.Euler(0, -vertical, 0);
        }
    }
    public void Collect()
    {
        throw new System.NotImplementedException();
    }
}
