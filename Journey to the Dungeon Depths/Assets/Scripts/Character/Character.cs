using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    [SerializeField]private Animator animator;
    [SerializeField]private CharacterAttributes attributes;
    [SerializeField]private List<Skill> skills;

    private Inventory inventory;
    private List<Effect> effects;
}
