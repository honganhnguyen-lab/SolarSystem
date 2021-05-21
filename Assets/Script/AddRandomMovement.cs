using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRandomMovement : MonoBehaviour
{
    public float minSpinSpeed = 5f;
    public float maxSpinSpeed = 10f;
    public float minThrust = 0.3f;
    public float maxThrust = 0.7f;
    private float spinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = Random.Range(minSpinSpeed, minSpinSpeed);
        float thrust = Random.Range(minThrust, maxThrust);
        Rigidbody rg = GetComponent<Rigidbody>();
        rg.AddForce(transform.forward * thrust, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
}
