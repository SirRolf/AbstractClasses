using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleEnemy : Tower
{
    protected override void Shoot()
    {
        print("shoot one guy");
    }

    protected override bool HasTarget()
    {
        // logica voor targetting singleEnemy
        var cols = Physics.OverlapSphere(transform.position, _radius, _layer);
        if (cols.Length > 0)
            _target = cols[0].transform;

        print("target is: " + _target);
        return true;
    }
}
