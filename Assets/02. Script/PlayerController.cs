using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField]
    private CharacterController controller;

    [Header("Specs")]
    [SerializeField]
    private float movePower;
    public float MovePower { get { return movePower; } }

    [Header("Ballancing")]
    [SerializeField]
    private Vector3 moveDir;
    [SerializeField]
    private float inputHzt;
    [SerializeField]
    private float inputVtc;

    private void Update()
    {
        Move();
    }

    private void OnMove(InputValue value)
    {
        inputHzt = value.Get<Vector2>().x;
        inputVtc = value.Get<Vector2>().y;
        moveDir = new Vector3(inputHzt, transform.position.y, inputVtc);
    }
    private void Move()
    {
        controller.Move(moveDir * movePower * Time.deltaTime);
    }
}
