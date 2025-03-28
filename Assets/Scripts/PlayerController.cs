using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerBody;
    private float impulse = 5;
    // prevent double jump
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
                
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerBody.AddForce(Vector3.up * impulse, ForceMode.Impulse);
            isOnGround = false;
        }
        
    }

    // Check if on ground prevent double jump
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
