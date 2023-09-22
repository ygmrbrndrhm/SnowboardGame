using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float TorqueAmount;
    Rigidbody2D rg2d;
    [SerializeField] SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 10f;
    bool CanMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove == true)
        {
            RotatePlayer();
            BoostMethod();
        }
    }
    public void DestroyMove()
    {
        CanMove = false;
    }
    void BoostMethod()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speedVariation = boostSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            surfaceEffector2D.speedVariation = baseSpeed;
        }
    }
     void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rg2d.AddTorque(TorqueAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rg2d.AddTorque(-TorqueAmount);
        }
    }
}
