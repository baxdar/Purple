using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

    public delegate void GenericDelegate();

    public class HealthClass {

        public GenericDelegate HealDelegate;
        public GenericDelegate DamageDelegate;
        public GenericDelegate DeathDelegate;

        private float _value;

        public HealthClass (float v) {
            _value = v;
        }
            
        public float Value {
            get { return _value; }
            set {
                if (value < 0) { //negative damage/healing
                    _value = value;
                    HealDelegate();
                }
                else if (value > 0) { //noraml damage
                    _value = value;
                    DamageDelegate();
                }
                if (_value <= 0) { //death check
                    DeathDelegate();
                }
            }
        }
    }

    public HealthClass Health;

    public abstract void Die();
}
