using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EffectComponent : SkillComponent {
    private EffectType type;
    private bool isPositive, isPermanent;
    private int duration;

    private AttributeModifier attributeModifier;
    private ConditionType conditionType;

    #region Getters

        public EffectType GetEffectType() {
            return type;
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

        public void SetEffectType(EffectType type) {
            this.type = type;
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
