using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicVehControls : MonoBehaviour
{

    public int bhp;
    public float torque;
    public int brakeTorque;

    public float[] gearRatio;
    public int currentGear;

    public WheelCollider FL;
    public WheelCollider FR;
    public WheelCollider RL;
    public WheelCollider RR;

    public float currentSpeed;
    public int maxSpeed;
    public int maxRevSpeed;

    public float SteerAngle;

    public float engineRPM;
    public float gearUpRPM;
    public float gearDownRPM;
    private GameObject COM;

	public bool handBraked;

	public float[] MinRpmTable = {50.0f, 75.0f, 112.0f, 166.9f, 222.4f, 278.3f, 333.5f, 388.2f, 435.5f, 483.3f, 538.4f, 594.3f, 643.6f, 692.8f, 741.9f, 790.0f};
	public float[] NormalRpmTable = {72.0f, 93.0f, 155.9f, 202.8f, 267.0f, 314.5f, 377.4f, 423.9f, 472.1f, 519.4f, 582.3f, 631.3f, 680.8f, 729.4f, 778.8f, 826.1f};
	public float[] MaxRpmTable = {92.0f, 136.0f, 182.9f, 247.4f, 294.3f, 357.5f, 403.6f, 452.5f, 499.3f, 562.5f, 612.3f, 661.6f, 708.8f, 758.9f, 806.0f, 1000.0f};
	public float[] PitchingTable = {0.12f, 0.12f, 0.12f, 0.12f, 0.11f, 0.10f, 0.09f, 0.08f, 0.06f, 0.06f, 0.06f, 0.06f, 0.06f, 0.06f, 0.06f, 0.06f};
	public float RangeDivider = 4f;

    private GameObject CountDown;
    public bool canMove = false;

    void Start()
    {
        CountDown = GameObject.Find("CountdownUI");
        Debug.Log(CountDown);
        StartCoroutine(CountStart());

        FL = GameObject.Find("FL.Col").GetComponent<WheelCollider>();
        FR = GameObject.Find("FR.Col").GetComponent<WheelCollider>();
        RL = GameObject.Find("RL.Col").GetComponent<WheelCollider>();
        RR = GameObject.Find("RR.Col").GetComponent<WheelCollider>();

        COM = GameObject.Find("Collider");
        GetComponent<Rigidbody>().centerOfMass = new Vector3(COM.transform.localPosition.x * transform.localScale.x, COM.transform.localPosition.y * transform.localScale.y, COM.transform.localPosition.z * transform.localScale.z);
    }

    IEnumerator CountStart() {
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text> ().text = "3";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text> ().text = "2";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text> ().text = "1";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        canMove = true;
    }

    void Update()
    {
        if (canMove == true) {
            //Functions to access.
            Steer();
            AutoGears();
            Accelerate();

            //Defenitions.
            currentSpeed = GetComponent<Rigidbody>().velocity.magnitude * 3.6f;
            engineRPM = Mathf.Round((RL.rpm * gearRatio[currentGear]));
            torque = bhp * gearRatio[currentGear];

            if (Input.GetButton("Jump"))
            {
                HandBrakes();
            }
            if (Input.GetKey(KeyCode.R)) {

                transform.position.Set(transform.position.x, transform.position.y + 5f, transform.position.z);
                transform.rotation.Set(0,0,0,0);
            }
        }
    }

    void Accelerate()
    {
        if (currentSpeed < maxSpeed && currentSpeed > maxRevSpeed && engineRPM <= gearUpRPM)
        {

            RL.motorTorque = torque * Input.GetAxis("Vertical");
            RR.motorTorque = torque * Input.GetAxis("Vertical");
            RL.brakeTorque = 0;
            RR.brakeTorque = 0;
        }
        else
        {
            RL.motorTorque = 0;
            RR.motorTorque = 0;
            RL.brakeTorque = brakeTorque;
            RR.brakeTorque = brakeTorque;
        }

		if (engineRPM > 0 && Input.GetAxis("Vertical") < 0 && engineRPM <= gearUpRPM)
		{
            FL.brakeTorque = brakeTorque;
            FR.brakeTorque = brakeTorque;
        }
        else
        {
            FL.brakeTorque = 0;
            FR.brakeTorque = 0;
        }
    }

    void Steer()
    {

        SteerAngle = 16 - (currentSpeed / 10);
  
        FL.steerAngle = SteerAngle * Input.GetAxis("Horizontal");
        FR.steerAngle = SteerAngle * Input.GetAxis("Horizontal");
    }

    void AutoGears()
    {

        int AppropriateGear = currentGear;

        if (engineRPM >= gearUpRPM)
        {

            for (var i = 0; i < gearRatio.Length; i++)
            {
                if (RL.rpm * gearRatio[i] < gearUpRPM)
                {
                    AppropriateGear = i;
                    break;
                }
            }
            currentGear = AppropriateGear;
        }

        if (engineRPM <= gearDownRPM)
        {
            AppropriateGear = currentGear;
            for (var j = gearRatio.Length - 1; j >= 0; j--)
            {
                if (RL.rpm * gearRatio[j] > gearDownRPM)
                {
                    AppropriateGear = j;
                    break;
                }
            }
            currentGear = AppropriateGear;
        }
    }

    void HandBrakes()
    {

        RL.brakeTorque = brakeTorque;
        RR.brakeTorque = brakeTorque;
        FL.brakeTorque = brakeTorque;
        FR.brakeTorque = brakeTorque;
    }
}
