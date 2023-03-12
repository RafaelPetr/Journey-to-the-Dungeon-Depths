using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour {
    //This class will control all events that occur inGame and call other managers when necessary
    private List<Creature> creatures = new List<Creature>();

    public static CombatController instance;
}