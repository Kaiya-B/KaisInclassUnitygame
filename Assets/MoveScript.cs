using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Animator animator;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()

    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); //1 
        float z = Input.GetAxis("Vertical"); //2 
        Vector3 move = (transform.right * x + transform.forward * z) * speed * Time.deltaTime; //3  

        animator.SetFloat("Speed_f", move.magnitude*4);

        if (Input.GetKey("up"))
        {
            transform.position += move; //4 
        }

        if (Input.GetKey("down"))
        {
            transform.position += move;
        }

        if (Input.GetKey("left"))
        {
            transform.position += move;
        }

        if (Input.GetKey("right"))
        {

            transform.position += move;

        }

        if (Input.GetKey("a"))
        {

            transform.position = transform.position + Vector3.up * speed;

        }

        if (Input.GetKey("z"))
        {

            transform.position = transform.position + Vector3.down * speed;

        }

        if (Input.GetKeyDown(KeyCode.Mouse0))  //1 

        {

            animator.SetInteger("WeaponType_int", 1);  //2 

            animator.SetBool("Shoot_b", true); //3 


        }
        else if (Input.GetKeyUp(KeyCode.Mouse0)) //5 

        {

            animator.SetInteger("WeaponType_int", 0); //6 

            animator.SetBool("Shoot_b", false);  //7 

        }

        /*
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { //1 

            transform.position = transform.position + Vector3.forward * 10; //2 

        }
        */
    }
}
    












  