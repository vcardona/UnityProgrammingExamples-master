using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Ikillable  
{
    void kill();
}

public interface IDamageable<T>
{
    void Damage(T damageTaken);
}
