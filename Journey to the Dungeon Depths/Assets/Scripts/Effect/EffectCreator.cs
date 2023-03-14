using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EffectCreator {
    [SerializeField]protected TargetType targetType;
    [SerializeField]protected int numberTargets = 2;
    [SerializeField]protected bool isRandom;
    [SerializeField]protected bool targetSelf;

    [SerializeField]private EffectType type;
    [SerializeField]private bool show, isPositive, isPermanent;
    [SerializeField]private int duration;

    [SerializeField]private AttributeModifier attributeModifier = new AttributeModifier();
    [SerializeField]private ConditionType conditionType;

    [SerializeField]private int damageModifier;
    [SerializeField]private DamageType damageType;

    #region Getters

        public int GetDamageModifier() {
            return damageModifier;
        }

        public DamageType GetDamageType() {
            return damageType;
        }

        public TargetType GetTargetType() {
            return targetType;
        }

        public int GetNumberTargets() {
            return numberTargets;
        }

        public bool GetTargetSelf() {
            return targetSelf;
        }

        public bool GetIsRandom() {
            return isRandom;
        }

        public EffectType GetEffectType() {
            return type;
        }

        public bool GetShow() {
            return show;
        }

        public bool GetIsPositive() {
            return isPositive;
        }

        public bool GetIsPermanent() {
            return isPermanent;
        }

        public int GetDuration() {
            return duration;
        }

        public AttributeModifier GetAttributeModifier() {
            return attributeModifier;
        }

        public ConditionType GetConditionType() {
            return conditionType;
        }

    #endregion

    #region Setters

        public void SetDamageModifier(int damageModifier) {
            this.damageModifier = damageModifier;
        }

        public void SetDamageType(DamageType damageType) {
            this.damageType = damageType;
        }

        public void SetTargetType(TargetType targetType) {
            this.targetType = targetType;
        } 

        public void SetNumberTargets(int numberTargets) {
            this.numberTargets = numberTargets;
        }

        public void SetTargetSelf(bool targetSelf) {
            this.targetSelf = targetSelf;
        }

        public void SetIsRandom(bool isRandom) {
            this.isRandom = isRandom;
        }

        public void SetEffectType(EffectType type) {
            this.type = type;
        }

        public void SetShow(bool show) {
            this.show = show;
        }

        public void SetIsPositive(bool isPositive) {
            this.isPositive = isPositive;
        }

        public void SetIsPermanent(bool isPermanent) {
            this.isPermanent = isPermanent;
        }

        public void SetDuration(int duration) {
            this.duration = duration;
        }

        public void SetAttributeModifier(AttributeModifier attributeModifier) {
            this.attributeModifier = attributeModifier;
        }

        public void SetConditionType(ConditionType conditionType) {
            this.conditionType = conditionType;
        }

    #endregion
}
