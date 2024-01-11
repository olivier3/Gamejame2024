using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMouvement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;


    [SerializeField]
    private Animator anim;

    private bool isMoving = false;
    private bool isUp = false;
    private bool isDown = false;
    private bool isLeft = false;
    private bool isRight = false;

    // Start is called before the first frame update

    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (vertical != 0)
        {
            if (!isMoving)
            {
                isMoving = true;
                anim.SetBool("IsMoving", true);
            }
            transform.position += new Vector3(0, vertical) * speed * Time.deltaTime;

        }

        if (horizontal != 0)
        {
            if (!isMoving)
            {
                isMoving = true;
                anim.SetBool("IsMoving", true);
            }
            transform.position += new Vector3(horizontal, 0) * speed * Time.deltaTime;

            
        }

        if (horizontal + vertical == 0)
        {
            resetBools();
            if (isMoving)
            {
                isMoving = false;
                anim.SetBool("IsMoving", false);
            }
        }


        if (vertical > 0 && !isUp)
        {
            resetBools();
            isUp = true;
            anim.SetTrigger("IsUp");
        }
        else if (vertical < 0 && !isDown)
        {
            resetBools();
            isDown = true;
            anim.SetTrigger("IsDown");
        }
        else if (horizontal < 0 && !isLeft)
        {
            resetBools();
            isLeft = true;
            anim.SetTrigger("IsLR");
            this.gameObject.transform.localScale = new Vector3(-9f, 9f, 1f);
        }
        else if (horizontal > 0 && !isRight)
        {
            resetBools();
            isRight = true;
            anim.SetTrigger("IsLR");
            this.gameObject.transform.localScale = new Vector3(9f, 9f, 1f);
        }

        setAnims();
    }

    void resetBools()
    {
        isUp = false;
        isDown = false;
        isLeft = false;
        isRight = false;
    }

    void setAnims()
    {
        anim.SetBool("IsUp", isUp);
        anim.SetBool("IsDown", isDown);
        anim.SetBool("IsLR", isLeft || isRight);
    }
}
