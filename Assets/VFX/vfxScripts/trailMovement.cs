using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteAlways]
public class trailMovement : MonoBehaviour
{
    [SerializeField]
    [Range(0f, 5f)]
    private float ampY = 1f;
    [SerializeField]
    [Range(0f, 4f)]
    private float frequencyY = 1f;
    [SerializeField]
    [Range(0f, 5f)]
    private float ampX = 1f;
    [SerializeField]
    [Range(0f, 4f)]
    private float frequencyX = 1f;
    [SerializeField]
    [Range(0f, 5f)]
    private float ampZ = 1f;
    [SerializeField]
    [Range(0f, 4f)]
    private float frequencyZ = 1f;
    private Vector3 startpos;
    void Start()
    {
        startpos = transform.position;
    }

    void Update()
    {
        float x = Mathf.Cos(Time.time * frequencyX) * ampX;
        float y = Mathf.Sin(Time.time * frequencyY) * ampY;
        float z = Mathf.Sin(Time.time * frequencyZ) * ampZ;

        transform.position =  new Vector3(x, y, z);


    }
}
