using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homwork : MonoBehaviour
{

    public float angle = 90.0f;
    public double maxCount = 100;
    int count = 0;
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = count + 1;
        Debug.Log(count);   //count의 값을 콘솔창에서 확인하기 위함
        if (count >= maxCount)
        {
            this.transform.Rotate(0, 0, angle);
            count = 0;
        }
        if (Input.GetKey("d")) // right == Keycode.Right 
        {
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, -speed, 0);
        }
        if (Input.GetMouseButtonUp(0)) //getmousebutton 0은 왼쪽클릭, 1은 오른쪽클릭, 2는 휠 //up은 누르는게 한번 down은 떼는게 1번  
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetMouseButtonDown(1))
        {
            transform.Translate(speed, 0, 0);
        }
    }
}
