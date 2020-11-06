using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterMovementController : MonoBehaviour
{
    public float speed = 1.0f;
    public Rigidbody2D m_rigid;
    private Vector3 movement;
    private float rotateAngle = 0.0f;
    public float rotateSpd = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(movement);
        //this.transform.position += movement;
        #region Movement
        /*if(Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0.0f, speed*Time.deltaTime, 0.0f));
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector3(0.0f, -1.0f*speed * Time.deltaTime, 0.0f));
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector3(-1.0f * speed * Time.deltaTime, 0.0f , 0.0f));
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector3(1.0f * speed * Time.deltaTime, 0.0f, 0.0f));
        }*/
        #endregion
    }
    private void FixedUpdate()
    {
        movement = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0f);
        if(movement != Vector3.zero)
        {
            rotateAngle = Vector3.Angle(Vector3.up, movement);
            Quaternion rotation = Quaternion.Euler(0, 0, rotateAngle);
            //transform.rotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.FromToRotation(Vector3.up, movement);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotateSpd);
            rotateAngle -= rotateSpd;
        }
        m_rigid.velocity = movement;
    }
}
