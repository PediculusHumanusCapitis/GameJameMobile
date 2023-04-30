using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform player = null;

    private void Start(){
        speed = Random.Range(1, 3);
    }

    private void FixedUpdate(){
        Move();
    }

    private void Move() {
        if(player!=null){
            Vector3 pos = player.position;
            transform.position = Vector3.MoveTowards(transform.position, pos, speed*Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            player = other.transform;
        }
    }




}
