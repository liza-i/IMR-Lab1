
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour
{
    public Transform Player;
    [SerializeField] private Animator anim;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(Camera.main.transform.position, Player.transform.position);
        if ( distance<17 && distance>=10)

        //if(Input.GetKeyDown("1"))
        {
            anim.Play("Attack");
        }
        else
            anim.Play("New State");

    }

}