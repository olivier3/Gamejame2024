using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMouvement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;


    [SerializeField]
    //private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //anim.SetBool("walk", false);
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.position += new Vector3(0, Input.GetAxis("Vertical")) * speed * Time.deltaTime;
            //anim.SetBool("walk", true);
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal"), 0) * speed * Time.deltaTime;
            //anim.SetBool("walk", true);
        }
    }
}
