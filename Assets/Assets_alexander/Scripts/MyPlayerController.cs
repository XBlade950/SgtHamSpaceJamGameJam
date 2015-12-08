﻿using UnityEngine;
using System.Collections;

public class MyPlayerController : MonoBehaviour {
    

    private Vector3 mousePosition;
    private Vector3 worldPosition;
    private Vector3 moveDirection = Vector3.zero;
    private float cameraDif;
    private float gravity = 20f;
    [SerializeField]
    private GameObject bullet;
    private CharacterController controller;
    public float jumpSpeed = 8f;
    public int OneShots = 4;
    private Animator animator;
    private Vector3 oldPos;
    private Actions actions;
    private PlayerController playControl;
    private Player player;
    [SerializeField]
    private int alive = 1;
   // public RuntimeAnimatorController aniControl;

    [SerializeField]
    private int speed;
	// Use this for initialization
	void Start () {
        cameraDif = Camera.main.transform.position.y - transform.position.y;
        bullet = (GameObject)Resources.Load("PlayerStandardBullet");
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        //animator.runtimeAnimatorController = aniControl;
        playControl = GetComponent<PlayerController>();
        actions = GetComponent<Actions>();
        playControl.SetArsenal("Rifle");
        player = GetComponent<Player>();
	}

    
	
	// Update is called once per frame
	void Update () {
        if (player.getHealth() > 0 && alive == 1)
        {
            worldPosition = Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(cameraDif);
            worldPosition.y = transform.position.y;
            transform.LookAt(worldPosition);



            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Left Mouse Clicked");
                Vector3 toInstantiate = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
                Instantiate(bullet, toInstantiate + (transform.forward * 1f), transform.rotation);
                actions.Aiming();
                //animator.SetBool("Death", true);


            }

            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("Right Mouse Clicked");
                if (player.getOneShots() > 0)
                {
                    bullet = (GameObject)Resources.Load("PlayerOneShotBullet");
                    Vector3 toInstantiate = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
                    Instantiate(bullet, toInstantiate + (transform.forward * 1.5f), transform.rotation);
                    bullet = (GameObject)Resources.Load("PlayerStandardBullet");
                    player.OneShot();
                }


            }

            if (Input.GetKeyDown("e"))
            {
                player.deployShield();
            }




            //Moves player with Character Controller
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(moveHorizontal, 0f, moveVertical);
                moveDirection *= speed;
            }

            if (Input.GetKeyDown("space") && controller.isGrounded)
            {
                Debug.Log("Space Pressed");
                actions.Jump();
                moveDirection.y = jumpSpeed;


            }


            moveDirection.y -= gravity * Time.deltaTime;

            if (oldPos != gameObject.transform.position)
            {
                actions.Walk();
            }
            else
                //actions.Stay();



                controller.Move(moveDirection * Time.deltaTime);
            //actions.Walk();
            //StartCoroutine(wait());
            oldPos = gameObject.transform.position;
        }
        if (player.getHealth() <= 0 && alive == 1)
        {
            actions.Death();
            alive--;
        }

	}

    
}
