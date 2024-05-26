using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateFall : MonoBehaviour
{
    public float additionalGravity;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.down * additionalGravity, ForceMode.Acceleration);
    }

    public void ChooseEasy()
    {
        additionalGravity = 5f;

    }

    public void ChooseMedium()
    {
        additionalGravity = 10f;
    }

    public void ChooseHard()
    {
        additionalGravity = 15f;
    }
}

