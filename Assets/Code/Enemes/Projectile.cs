using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    private Vector3 directionPoint;
    private bool targetFound = false;
    public float z;

    void Start()
    {
        directionPoint = transform.position;
        
    }

    private void FixedUpdate(){
        Move();
        Remove();
    }

    private void Move() {
        if (targetFound){
            transform.position = Vector3.MoveTowards(transform.position, directionPoint, speed * Time.deltaTime);
        }
    }
    private void Remove(){
        if(transform.position == directionPoint && targetFound){
            Destroy(this.gameObject);
        }
    }
    private void Rotates(){
        float a = Mathf.Abs(Mathf.Abs(directionPoint.y) - Mathf.Abs(transform.position.y));
        float b = Mathf.Abs(Mathf.Abs(directionPoint.x) - Mathf.Abs(transform.position.x));
        z = Mathf.Atan(a / b);
        transform.Rotate(0, 0, z);
    }

    


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            targetFound = true;
            directionPoint = other.transform.position;
            Rotates();
        }
    }

}
