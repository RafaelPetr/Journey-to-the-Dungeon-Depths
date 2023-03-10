using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeModifier {
    private int value;
    private AttributeType attributeType;
    private AttributeModifierType modifierType;

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