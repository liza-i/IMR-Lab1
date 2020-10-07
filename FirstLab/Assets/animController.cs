
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour
{
    public Transform Player;
    [SerializeField] private Animator anim;
    public float distance;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        Player = GameObject.FindWithTag("Player").transform;
    }

   
    void Update()
    {
        distance = Vector3.Distance(Camera.main.transform.position, Player.transform.position);
        if ( distance<17 && distance>=10)

    
        {
            anim.Play("Attack");
        }
        else
            anim.Play("New State");

    }

}
