using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool onGround;
    public float ForceJump = 800;
    public float  fuerza_x;
    public float incremento = 200f;
    private bool teclaZpresionada = false;
    private bool teclaXpresionada = false;
    
    // Start is called before the first frame update
    void Start()
    {
        onGround=false;
        fuerza_x=0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Space key was released");
            if(GetComponent<Rigidbody>() != null){
            GetComponent<Rigidbody>().useGravity = true;
           }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if(onGround)
            {
             Vector3 fuerza = new Vector3 (fuerza_x,ForceJump,0);
             GetComponent<Rigidbody>().AddForce(fuerza);
            }
        }

         if (Input.GetKeyDown(KeyCode.Z))
        {
            teclaZpresionada= true;
        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            teclaZpresionada= false;
        }
        
        if (teclaZpresionada)
        {
            fuerza_x -= incremento* Time.deltaTime;
        }
        
        
        if (Input.GetKeyDown(KeyCode.X))
       {
           teclaXpresionada= true;
       }
       else if (Input.GetKeyUp(KeyCode.X))
       {
           teclaXpresionada= false;
       }
       
       if (teclaXpresionada)
       {
           fuerza_x += incremento* Time.deltaTime;
       }
    }

    private void OnCollisionEnter(Collision c){
        Debug.Log("Colision");
        onGround = true;
    }

     private void OnCollisionStay(Collision c){
        
        onGround = true;
    }

     private void OnCollisionExit(Collision c){
        onGround = false;
        Debug.Log("Libre");
       
    }
}
