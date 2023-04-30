using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_2 : MonoBehaviour
{
    [SerializeField] private GameObject player = null;
    [SerializeField] private GameObject projectile;
    [SerializeField] private float ShootingDistance= 10f;
    public bool shootingIsComing = false;
    public bool shootingAllowed = false;



    private void SpavnProjectile(){

        CheckDistant();
        if (shootingAllowed){
            Vector3 pos = transform.position;
            GameObject newProjectile = Instantiate<GameObject>(projectile);
            newProjectile.transform.position = pos;
            Invoke("SpavnProjectile", 2f);
        }

    }

    private void CheckDistant(){
        float distanceToTarget = Vector3.Distance(player.transform.position, transform.position);
        if(distanceToTarget>ShootingDistance){
            shootingAllowed = false;
            shootingIsComing = false;
        }
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && !shootingIsComing){
            shootingAllowed = true;
            shootingIsComing = true;
            player = other.gameObject;
            SpavnProjectile();
            CheckDistant();
        }
    }

}
