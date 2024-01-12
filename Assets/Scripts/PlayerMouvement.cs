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
    private float offsetX = 0f;
    private float offsetY = 0f;

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
            anim.SetFloat("MoveY", vertical);
            offsetY = vertical * 0.01f;
            offsetX = 0f;
            transform.position += new Vector3(0, vertical) * speed * Time.deltaTime;
        }

        if (horizontal != 0)
        {
            anim.SetFloat("MoveX", horizontal);
            offsetX = horizontal * 0.01f;
            offsetY = 0f;
            transform.position += new Vector3(horizontal, 0) * speed * Time.deltaTime;
        }

        if (horizontal + vertical == 0)
        {
            anim.SetFloat("MoveY", vertical + offsetY);
            anim.SetFloat("MoveX", horizontal + offsetX);
        }

        if (horizontal < 0)
        {
            anim.SetTrigger("IsLR");
            this.gameObject.transform.localScale = new Vector3(-9f, 9f, 1f);
        }
        if (horizontal > 0)
        {
            anim.SetTrigger("IsLR");
            this.gameObject.transform.localScale = new Vector3(9f, 9f, 1f);
        }

    }
}
