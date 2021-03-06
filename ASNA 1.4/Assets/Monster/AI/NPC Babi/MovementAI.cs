using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AIMotor))]
public class MovementAI : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    Rigidbody rb;
    Animator anim;

    AIMotor motor;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        motor = GetComponent<AIMotor>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isWandering == false)
        {
            StartCoroutine(Wander());
        }

        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
        }

        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
        }

        if(isWalking == true)
        {
            rb.AddForce(transform.forward * movementSpeed);
            anim.SetBool("isWalking", true);
        }

        if (isWalking == false)
        {
            anim.SetBool("isWalking", false);
        }
    }

    IEnumerator Wander()
    {
        int rotationTime = Random.Range(1, 30);
        int rotateWait = Random.Range(1, 30);
        int rotateDirection = Random.Range(1, 30);
        int walkWait = Random.Range(1, 3);
        int walkTime = Random.Range(1, 3);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);

        isWalking = true;

        yield return new WaitForSeconds(walkTime);

        isWalking = false;

        yield return new WaitForSeconds(rotateWait);

        if(rotateDirection == 1)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingLeft = false;
        }

        if (rotateDirection == 2)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingRight = false;
        }

        isWandering = false;

    }
}
