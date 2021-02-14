using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTrigger : MonoBehaviour
{
    public GameObject EndTripper;
    public GameObject HalfTripper;

    void OnTriggerEnter() {
        EndTripper.SetActive(true);
        HalfTripper.SetActive(false);
    }
}
