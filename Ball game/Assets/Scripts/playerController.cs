using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public GameObject Wall;
  public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int count;

    public Transform cam;
    public float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();

        // Set the text property of the Win Text UI to an empty string, making the 'You Win' (game over message) blank
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(movementX, 0.0f, movementY);
        
        
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity,
                turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            rb.AddForce(moveDir * speed);
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            // Run the 'SetCountText()' function (see below)
            SetCountText ();
        }
        
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString() + "/3";

        if (count >= 3) 
        {
            Destroy(Wall);
            winTextObject.SetActive(true);
            Invoke("DisableText", 5F);
            
        }
    }

    void DisableText()
    {
        winTextObject.SetActive(false);
    }
}
