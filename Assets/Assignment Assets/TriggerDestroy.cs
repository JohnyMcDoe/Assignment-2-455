using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroy : MonoBehaviour
{
    public GameObject EvilPole;
    void OnTriggerEnter(Collider other)
    {
        Destroy(EvilPole);
    }
}
