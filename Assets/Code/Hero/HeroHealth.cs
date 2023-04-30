using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHealth : MonoBehaviour
{
    private HeroStats stats;
    [SerializeField] private float healsPoints;

    private void Start()
    {
        stats = GetComponent<HeroStats>();
        CheckHeals();
    }
    
    private void CheckHeals(){
        healsPoints = stats.HealthPoints;
    }

    public void TakeDamage(){
        healsPoints--;
        if(healsPoints<=0){
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D Collis){
        if (Collis.gameObject.tag == "Enemy" || Collis.gameObject.tag=="EnemyProjectile"){
            TakeDamage();
        }
    }
}
