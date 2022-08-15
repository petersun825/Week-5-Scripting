using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Header("movement parameters")]
    public Vector3 movementAxis;
    public float movementSpeed;
    public float movementDistance;

    [Header("movement positions")]
    public Vector3 startingPosition;
    public Vector3 positiveEnd;
    public Vector3 negativeEnd;

    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        //the direction of movement
        direction = movementAxis.normalized;

        //precompute positions
        startingPosition = transform.position;
        positiveEnd = transform.position + (direction * movementDistance);
        negativeEnd = transform.position - (direction * movementDistance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if reach bounds of movement, reverse the direction vector
        if (Vector3.Distance(transform.position, positiveEnd) < 0.01f || Vector3.Distance(transform.position, negativeEnd) < 0.01f)
            direction = direction * -1;

        //move the platform velocity vector
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
}
