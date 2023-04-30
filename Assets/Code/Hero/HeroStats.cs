using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStats : MonoBehaviour
{
    private float maxLevelHero = 10;
    [SerializeField] private float levelHero = 1;
    private float maxSpeedHero = 3;
    [SerializeField] private float speedHero=1;

    private float maxHealthPoints = 13;
    [SerializeField] float healthPoints = 3;

    public float  Speed{
        get => speedHero;
        set => speedHero=value;
    }
    public float HealthPoints{
        get => healthPoints;
        set => healthPoints = value;
    }

    public void LevelUp(){
        if(levelHero<maxLevelHero){
            levelHero++;
            if(speedHero<maxSpeedHero){
                speedHero++;
            }
            if(healthPoints<maxHealthPoints){
                healthPoints++;
            }
        }
    }









}
