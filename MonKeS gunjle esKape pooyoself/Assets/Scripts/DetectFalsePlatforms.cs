using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;

    void Update()
    {
        hit = Physics.Raycast(transform.position, transform.forward, 10.0f);
        Debug.DrawRay(transform.position, transform.forward * 10.0f, Color.red);

        if (hit == false)
        {
            Debug.LogWarning("Be careful lazy a** bi***");
        } else
        {
            Debug.Log("All clear so lose some wheigh fat a**");
        }
    }
}
