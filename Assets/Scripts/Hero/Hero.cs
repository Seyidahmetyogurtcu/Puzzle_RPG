using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Puzzle_RPG
{
    public abstract class Hero : MonoBehaviour
    {
        public int Property { get; protected set; }

        public void Damage()
        {


        }
        public void Attack()
        {

        }

        public abstract void SpecialPower();
    }
}

