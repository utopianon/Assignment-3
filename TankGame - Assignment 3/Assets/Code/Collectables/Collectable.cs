using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class Collectable : MonoBehaviour
    {
        [SerializeField]
        int value;

        PlayerUnit player;

        public int Value
        {
            get { return value; }
        }      

    }
}
