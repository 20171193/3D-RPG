using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private Animator anim;

    [Header("Specs")]
    [SerializeField]
    private float movePower;
    public float MovePower { get { return movePower; } }

    [Header("Ballancing")]
    [SerializeField]
    private float inputHzt;
    [SerializeField]
    private float inputVtc;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void OnMove(InputValue value)
    {
        inputHzt = value.Get<Vector2>().x;
        inputVtc = value.Get<Vector2>().y;
    }
    private void Move()
    {
        Vector3 fowardDir = Camera.main.transform.forward;
        fowardDir = new Vector3(fowardDir.x, 0, fowardDir.z).normalized;
        Vector3 rightDir = Camera.main.transform.right;
        rightDir = new Vector3(rightDir.x, 0, rightDir.z).normalized;

        controller.Move(fowardDir * inputVtc * movePower * Time.deltaTime);
        controller.Move(rightDir * inputHzt * movePower * Time.deltaTime);

        Vector3 lookDir = fowardDir * inputVtc + rightDir * inputHzt;

        if (lookDir != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(lookDir);
            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * 10f);
        }

        anim.SetFloat("MoveXSpeed", Mathf.Abs(inputHzt));
        anim.SetFloat("MoveZSpeed", Mathf.Abs(inputVtc));
    }
}
