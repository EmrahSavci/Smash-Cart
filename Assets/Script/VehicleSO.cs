using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Vehicle",menuName ="Vehicle/Car/Opsions")]
public class VehicleSO : ScriptableObject
{
    public float CurrentSpeed;
    public float MaxSpeed;
    public float RotateSpeed;
}
