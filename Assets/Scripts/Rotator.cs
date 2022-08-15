using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Tooltip("this is the rotation axis")]
    [SerializeField]
    private Vector3 rotationAxis = Vector3.up;
    [Tooltip("this is the rotation speed")]
    [SerializeField]
    public float rotationSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed);
    }
}
