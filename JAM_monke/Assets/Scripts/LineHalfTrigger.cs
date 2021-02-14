using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LineHalfTrigger : MonoBehaviour
{
    public GameObject EndTripper;
    public GameObject HalfTripper;

    public GameObject EndLaps;
    public int LapsDone;

    void OnTriggerEnter() {
        LapsDone += 1;
        EndLaps.GetComponent<Text>().text = "" + LapsDone;
        EndTripper.SetActive(false);
        HalfTripper.SetActive(true);

        if (LapsDone == 2)
            SceneManager.LoadScene("VictoryScene");
    }
}
