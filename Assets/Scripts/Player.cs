using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Move();
      RotateCharacter();
    }
    void Move()
    {
      float h = Input.GetAxis("Horizontal");
      float v = Input.GetAxis("Vertical");
      transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
    }
    void RotateCharacter()
    {
    float horizontalSpeed = 3f;
    float h = horizontalSpeed * Input.GetAxis("Mouse X");
    transform.Rotate(0, h, 0);
    }
}
