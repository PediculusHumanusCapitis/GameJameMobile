using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Joystick joystick;
    private Rigidbody2D rgb;
    private HeroStats stats;


    private void Start(){
        rgb = GetComponent<Rigidbody2D>();
        stats = GetComponent<HeroStats>();
        CheckSpeed();
    }
    private void FixedUpdate() {
        Move();
    }
    private void Move(){
        float translationY = joystick.Vertical * speed;
        float translationX = joystick.Horizontal * speed;
        Vector3 movement = new Vector3(translationX, translationY, 0);
        rgb.velocity = movement;
    }

    private void CheckSpeed(){
        speed = stats.Speed * 1.5f + 3f;
    }
}
