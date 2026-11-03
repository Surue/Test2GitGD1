using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<Enemy> _allEnemies;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="position"></param>
    /// <returns>Can be null</returns>
    public Enemy GetNearestEnemy(Vector3 position)
    {
        foreach (Enemy allEnemy in _allEnemies)
        {
            // return nearest enemy   
        }

        return null;
    }
}

public class Enemy : MonoBehaviour // <- class
{
    [SerializeField] private int _initialHealth;
    
    private int _currentHealth; // <- Member
    
    private bool _isDead;
    private float _float;
    private double _double;

    private List<Enemy> _list;
    private Enemy[] _array;
    private Queue<Enemy> _queue;
    private Dictionary<int, Enemy> _dictionary;
    
    public enum Status
    {
        Alive,
        Dead,
    }
    
    /// <summary>
    /// Get health point
    /// </summary>
    /// <returns>if 0 the enemy is dead</returns>
    public int GetHealthPoint() // <- Method
    {
        return _currentHealth;
    }

    public void SetHealthPoint(int newHealthPoint)
    {
        _currentHealth = newHealthPoint;
    }
    
    private void Awake()
    {
        
    }

    private void Start()
    {
        int oldHealthPoint = _currentHealth;
    }

    private void Update()
    {
    }
}

public class MyClass
{
    private EnemyManager _enemy;

    public void Foo()
    {
        _enemy.GetNearestEnemy(Vector3.zero);
    }
}
