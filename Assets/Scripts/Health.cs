using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float healthPoints = 100;

    public DamageType Type = DamageType.enemy;
    public float HealthPoints
    {
        get => HealthPoints;
        set
        {
            healthPoints = value;
            if (healthPoints <= 0)
            {
                //TODO: gestionar muerte del player/enemy
            }
        }
    }
}
