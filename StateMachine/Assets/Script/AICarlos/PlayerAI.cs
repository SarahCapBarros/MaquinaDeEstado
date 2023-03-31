using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerAI : MonoBehaviour
{
    public Camera cam;
    public float speed;
    public float cameraDistance;
    public float cameraHeight;
    public bool inv { get; private set; }

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        inv = false;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        moveDirection = transform.TransformDirection(movement) * speed;

        controller.Move(moveDirection * Time.deltaTime);
        cam.transform.position = transform.position - transform.forward * cameraDistance + Vector3.up * cameraHeight;
        cam.transform.rotation = Quaternion.LookRotation(transform.forward, Vector3.up);

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (!inv)
            {
                inv = true;
                Debug.Log("Invencivel");
            }
            else
            {
                inv = false;
                Debug.Log("Nao Invencivel");
            }
        }
    }
}