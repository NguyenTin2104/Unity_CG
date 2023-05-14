using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3[] checkPoints;
    public Vector3[] checkPointsTurn;
    public int turnIndex;
    public int targetIndex;
    public float speed = 1;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = checkPoints[targetIndex];
        
        Vector3 turnPosition = checkPointsTurn[turnIndex];
        //move
        if ((transform.position - targetPosition).magnitude > 0.5)
        {
            MoveTo(targetPosition);
        }
        else
        {
            targetIndex++;
            if (targetIndex >= checkPoints.Length) targetIndex = 0;
        }
        void MoveTo(Vector3 target)
        {
            Vector3 position = transform.position;
            Vector3 angles = transform.eulerAngles;
            if (position.x < target.x && target.x - position.x > 0.1)
            {
                if (target.x - position.x < 7.0f && target.x - position.x > 0.3f)
                {
                    angles.y += (speed * -900);
                }
                position.x += speed;
            }

            if (position.x > target.x && position.x - target.x > 0.1)
            {
                if (position.x - target.x < 7.0f && position.x - target.x > 0.3f)
                {
                    angles.y += (speed * -900);
                }
                position.x -= speed;
            }

            if (position.z < target.z && target.z - position.z > 0.1)
            {
                if(target.z - position.z < 7.0f && target.z - position.z > 0.3f)
                {
                    angles.y += (speed * -900);
                }
                position.z += speed;
            }

            if (position.z > target.z && position.z - target.z > 0.1)
            {
                if (position.z - target.z < 7.0f && position.z - target.z > 0.3f)
                {
                    angles.y += (speed * -900);
                }
                position.z -= speed;
            }
            transform.position = position;
            transform.eulerAngles = angles;
        }
        //turn
/*        if ((transform.position - targetPosition).magnitude > 0.5)
        {
            Turn(turnPosition);
        }
        else
        {
            turnIndex++;
            if (targetIndex >= checkPointsTurn.Length) targetIndex = 0;
        }
        //func turn
        void Turn(Vector3 turn)
        {
            Vector3 angles = transform.eulerAngles;
            Vector3 position = transform.position;
          *//*  if (position.x > turn.x && position.x - turn.x > 0.0001f)
            {
                position.x -= speed;
            }

            if (position.x < turn.x && turn.x - position.x > 0.0001f)
            {
                position.x += speed;
            }*//*

            if (position.z > turn.z && position.z - turn.z > 0.1 && angles.y <= 270 && angles.y > 90)
            {
                angles.y += speed;
            }

            if (position.z < turn.z && turn.z - position.z > 0.1 && angles.y <= 90)
            {
                angles.y += speed;
            }

            transform.eulerAngles = angles;

        }*/
    }
}
