﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2D : MonoBehaviour {

    public float mMass = 1.0f;
    public float mNumBalls = 0;
    public float mRadius;
    public HVector2D mVel;
    public  HVector2D mPos = new HVector2D(0,0);

    // temp usage
    private HMatrix2D matrix = new HMatrix2D();  
    private Vector2 tempPos = new Vector2();

    // Use this for initialization
    void Start () {
        mVel = new HVector2D(0,0);

        mRadius = GlobalVariable.BALL_SIZE / 2;
    }
	
	// Update is called once per frame
	void Update () {

    }

    private void FixedUpdate()
    {
     
    }

    public bool isCollidingWith(float x, float y)
    {

    }

    public bool isCollidingWith(Ball2D other)
    {
   
    }

    // Falls inside a hole
    public bool isInside(Hole2D hole)
    {

    }

    public void UpdatePhysics()
    {
        updateBoundaryCollision(Time.deltaTime);
        updatePhysics(Time.deltaTime);
    }

    public bool updatePhysics(float elapsed)
    {
        // get the object position
        mPos.x = transform.position.x;
        mPos.y = transform.position.y;

		//-------------------------------------------
		
		
		
		
		
		
		
		
		
		
		
		
		//-----------------------------------------------
        tempPos.x = mPos.x;
        tempPos.y = mPos.y;

        transform.position = tempPos;
        // transform.position = new Vector2(transform.position.x + mVel.x, transform.position.y + mVel.y);
        return true;
    }

    void updateBoundaryCollision(float elapsed)
    {
        mPos.x = transform.position.x;
        mPos.y = transform.position.y;
		//------------------------------------------------------
    
	
	
	
	
	

	
	
	
		//--------------------------------------------------------
        tempPos.x = mPos.x;
        tempPos.y = mPos.y;

        transform.position = tempPos;
    }

}
