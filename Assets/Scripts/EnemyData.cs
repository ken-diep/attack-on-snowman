using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Enemy", order = 1)]

public class EnemyData : ScriptableObject
{
    public int speed;
    public int damage;
    public int mass;
    public int hp;
}
