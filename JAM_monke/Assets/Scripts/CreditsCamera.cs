using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 
 
public class CreditsCamera : MonoBehaviour 
{ 
    public float forwardSpeed; 
    // Start is called before the first frame update 
    void Start() 
    { 
         
    } 
 
    // Update is called once per frame 
    void Update() 
    { 
        transform.Translate(0f, forwardSpeed * Time.deltaTime, 0f, null);
        Debug.Log(transform.position.y);
        if (Input.GetMouseButton(0) && transform.position.y >= 2245) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
        if (transform.position.y >= 2245) 
            forwardSpeed = 0; 
    } 
} 