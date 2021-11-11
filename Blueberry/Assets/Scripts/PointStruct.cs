/*
using System;
using UnityEngine;

public class Physics : HitboxArea
{
    private Vector2 _remainder = Vector2.zero;
    private float _ostatok;

    protected void MoveX(float amount, Action onCollision)
    {
        _remainder.x += amount;
        int move = Mathf.RoundToInt(_remainder.x);
        if (move != 0)
        {
            _remainder.x -= move;
            MoveExactX(move, onCollision);
        }
    }
    private void MoveExactX(int amount, Action onCollision)
    {
        int move = amount;
        int sign = Math.Sign(amount);
        float pixelDisplacement = sign / PixelsPerUnit;
        while(move != 0)
        {
            if (WallCheck(pixelDisplacement))
            {
                onCollision?.Invoke();
                return;
            }
            Rect newRect = Rect;
            newRect.center += new Vector2(pixelDisplacement, 0f);
            Rect = newRect;
            if(Rect.center.x % pixelDisplacement != 0)
                Debug.LogError("Module not zero!");

            transform.position = Rect.center;
            
            if(transform.position.x % pixelDisplacement != 0)
                Debug.LogError("Module not zero!");
            move -= sign;
        }
    }
    protected void MoveY(float amount, Action onCollision)
    {
        _remainder.y += amount;
        int move = Mathf.RoundToInt(_remainder.y);
        if (move != 0)
        {
            _remainder.y -= move;
            MoveExactY(move, onCollision);
        }
    }
    private void MoveExactY(int amount, Action onCollision)
    {
        int move = amount;
        int sign = Math.Sign(amount);
        float pixelDisplacement = sign / PixelsPerUnit;
        
        while(move != 0)
        {
            if (GroundRoofCheck(pixelDisplacement))
            {
                onCollision?.Invoke();
                return;
            }
            Rect newRect = Rect;
            newRect.center += new Vector2(0f, pixelDisplacement);
            Rect = newRect;
            if(Rect.center.x % pixelDisplacement != 0)
                Debug.LogError("Module not zero!");

            transform.position = Rect.center;
            
            if(transform.position.y % pixelDisplacement != 0)
                Debug.LogError("Module not zero!");
            move -= sign;
        }
    }
    protected void ZeroRemainderX()
    {
        _remainder.x = 0;
    }
    protected void ZeroRemainderY()
    {
        _remainder.y = 0;
    }
    private bool GroundRoofCheck(float displacement)
    {
        return Check<Solid>(new Vector2(0, displacement));
    }

    protected bool GroundCheck()
    {
        return Check<Solid>(new Vector2(0, -1 / PixelsPerUnit));
    }
    private bool WallCheck(float displacement)
    {
        return Check<Solid>(new Vector2(displacement, 0));
    }
}
*/
/*private float PixelClamp(float displacement, float pixelsPerUnit)
{
    /*int displacementInPixels = Mathf.RoundToInt(displacement * pixelsPerUnit);
    return displacementInPixels / pixelsPerUnity;#1#
        
    _ostatok += displacement * pixelsPerUnit;
    float displacementInPixels = Mathf.Round(_ostatok);
    _ostatok -= displacementInPixels;

    return displacementInPixels / pixelsPerUnit;
}*/

/*public class Player : Actor
{
    private const float MAX_RUN_SPEED = 256f;
    private const float MAX_FALL_SPEED = 410f;
    private const float RUN_ACCEL = 2048f;
    private const float GRAVITY = 1000f;
    private const float JUMP_SPEED = -410f;
    private const float JUMP_X_BOOST = 30f;
    private const float HALF_GRAV_THRESHOLD = 40;
    private const float RUN_ACCEL_AIR_MULT = 0.5f;

    [SerializeField] private Vector2 _speed;

    private void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _speed.y = JUMP_SPEED;
            //_speed.x += JUMP_X_BOOST * input.x;
        }
        else
        {
            /*float multiplier;
            if (Input.GetKey(KeyCode.Space) && Mathf.Abs(_speed.y) <= HALF_GRAV_THRESHOLD)
            {
                multiplier = 0.5f;
            }
            else
                multiplier = 1f;
            _speed.y = Approach(_speed.y, MAX_FALL_SPEED, GRAVITY  * Time.deltaTime);#1#
        }

        /*float accel = RUN_ACCEL;
        if (!_onGround)
            accel *= RUN_ACCEL_AIR_MULT;#1#
        
        _speed.x = Approach(_speed.x, Input.GetAxisRaw("Horizontal") * MAX_RUN_SPEED, RUN_ACCEL * Time.deltaTime);

        //MoveY(-_speed.y * Time.deltaTime, OnCollideY);
        MoveX(_speed.x * Time.deltaTime, OnCollideX);
    }
    
    private float Approach(float value, float target, float maxDelta)
    {
        
        return value > target ? Mathf.Max(value - maxDelta, target) 
            : Mathf.Min(value + maxDelta, target);
    }

    private void OnCollideX()
    {
        Debug.Log("Collision on the X-axis happened!");
        _speed.x = 0;
        ZeroRemainderX();
    }
    /*private void OnCollideY()
    {
        Debug.Log("Collision on the Y-axis happened!");
        _speed.y = 0;
        ZeroRemainderY();
    }#1#
}*/
