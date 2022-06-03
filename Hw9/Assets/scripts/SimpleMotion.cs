using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMotion : MonoBehaviour
{
    [SerializeField] private float _speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Movement(Vector3.forward);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            Movement(Vector3.back);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Movement(Vector3.right);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Movement(Vector3.left);
        }
    }

    private void Movement(Vector3 direction)
    {
        transform.position = transform.position + direction * _speed * Time.deltaTime;
    }
}
