using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinining : MonoBehaviour
{
    [SerializeField] float valX = 0f;
    [SerializeField] float valY = 0.5f;
    [SerializeField] float valZ = 0f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(valX, valY, valZ);
    }
}
