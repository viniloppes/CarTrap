using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float turnSpeed = 2f;

    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;

    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera hoodCamera;
    [SerializeField] public KeyCode switchKey = KeyCode.F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControlVehicle();

        //transform.Translate(Time.deltaTime * Vector3.right * turnSpeed * horizontalInput);
        SwitchCamera();


        if(transform.position.z > 180)
        {
            SceneManager.LoadScene(0);
        }
        if (transform.position.y < -1)
        {
            SceneManager.LoadScene(0);
        }
    }

    void ControlVehicle()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 aceleracao = Time.deltaTime * Vector3.forward * speed * verticalInput;
        transform.Translate(aceleracao);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }

    void SwitchCamera()
    {
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            
        }
    }
}
