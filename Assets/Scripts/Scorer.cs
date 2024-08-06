using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    static int score;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        { 
        score++;
        Debug.Log($"You have bumped into objects {score} times!");
        }
    }
}
