using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Attribute {
    [SerializeField]private int value;
    [SerializeField]private AttributeGrowthType growthType;
    private List<AttributeModifier> modifiers;

    #region Add

        public void AddModifier(AttributeModifier modifier) {
            modifiers.Add(modifier);
        }

    #endregion

    #region Remove

        public void RemoveModifier(AttributeModifier modifier) {
            modifiers.Remove(modifier);
        }

        public void RemoveModifier(int index) {
            modifiers.RemoveAt(index);
        }

    #endregion

    #region Getters

        public int GetValue() {
            return value;
        }

        public AttributeGrowthType GetLevelType() {
            return growthType;
        }

        public List<AttributeModifier> GetModifiers() {
            return modifiers;
        }

        public AttributeModifier GetModifiers(int index) {
            return modifiers[index];
        }

    #endregion

    #region Setters

        public void SetValue(int value) {
            this.value = value;
        }

        public void SetLevelType(AttributeGrowthType growthType) {
            this.growthType = growthType;
        }

        public void SetModifiers(List<AttributeModifier> modifiers) {
            this.modifiers = modifiers;
        }

    #endregion
}