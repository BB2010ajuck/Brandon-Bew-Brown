using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretLook : MonoBehaviour
{
    public Transform player;
    private LaserSwitch laserSwitch;
    private GameObject laser;
    public bool LasersAreOff = false;

    private void Start()
    {
        laserSwitch = GameObject.Find("LaserSwitch").GetComponent<LaserSwitch>();
        laser = transform.Find("Laser").gameObject;
    }

    void Update() 
    {
        if (laserSwitch.LasersAreOff)
        {
            laser.SetActive(false);
            return;
        }
        transform.LookAt(player);
    }
}
