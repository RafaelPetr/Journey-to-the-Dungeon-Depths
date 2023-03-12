using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AttributeModifier {
    [SerializeField]private int value;
    [SerializeField]private AttributeType attributeType;
    [SerializeField]private AttributeModifierType modifierType;

    #region Getters

        public int GetValue() {
            return value;
        }

        public AttributeType GetAttributeType() {
            return attributeType;
        }

        public AttributeModifierType GetModifierType() {
            return modifierType;
        }

    #endregion

    #region Setters

        public void SetValue(int value) {
            this.value = value;
        }

        public void SetAttributeType(AttributeType attributeType) {
            this.attributeType = attributeType;
        }

        public void SetModifierType(AttributeModifierType modifierType) {
            this.modifierType = modifierType;
        }

    #endregion
}