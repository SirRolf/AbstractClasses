using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private enum TargetSystem
    {
        SingleEnemyTarget,
        MultiEnemyTarget,
        SingleFriendlyTarget
        
    }
    
    [Header("Targeting")] 
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _layer;
    [SerializeField] private TargetSystem _targetSystem;
   
    private Transform _target;

    private void Update()
    {
        if (HasTarget())
            Shoot();
    }

    private void Shoot()
    {
        switch (_targetSystem)
        {
            case TargetSystem.SingleEnemyTarget:
                // shoot single enemy
                break;
            case TargetSystem.MultiEnemyTarget:
                // shoot multiple enemy
                break;
            case TargetSystem.SingleFriendlyTarget:
                // 'shoot' single friendly
                break;
        }
    }

    private bool HasTarget()
    {
        switch (_targetSystem)
        {
            case TargetSystem.SingleEnemyTarget:
                // logica voor targetting singleEnemy
                var cols = Physics.OverlapSphere(transform.position, _radius, _layer);
                if (cols.Length > 0)
                    _target = cols[0].transform;

                print("target is: " + _target);
                return true;
                break;

            case TargetSystem.MultiEnemyTarget:
                // logica voor targetting multiplteEnemy
                return true;
                break;
            case TargetSystem.SingleFriendlyTarget:
                // logica voor targetting SingleFriendly
                return true;
                break;
        }
        return false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
