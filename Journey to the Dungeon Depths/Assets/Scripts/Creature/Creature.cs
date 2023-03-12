using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour {
    [SerializeField]private Animator animator;
    [SerializeField]private Stats stats;
    [SerializeField]private List<Skill> skills;

    private Inventory inventory;
    private List<Effect> effects;

    /*public void DealDamage(float damagePercent = 1f, Character target) {

    }*/
}
