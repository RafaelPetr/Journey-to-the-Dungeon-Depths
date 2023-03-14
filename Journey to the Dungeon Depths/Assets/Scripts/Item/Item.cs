using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject {
    [SerializeField]protected string itemName;
    [SerializeField,TextArea(3,10)]protected string description;

    [SerializeField]protected Sprite sprite;
    [SerializeField]protected List<EffectCreator> effects = new List<EffectCreator>();

    public abstract void Use();

    #region Add

        public void AddEffect(EffectCreator effect) {
            effects.Add(effect);
        }

    #endregion

    #region Remove

        public void RemoveEffect(EffectCreator effect) {
            effects.Remove(effect);
        }

        public void RemoveEffect(int index) {
            effects.RemoveAt(index);
        }

    #endregion

    #region Getters

        public string GetName() {
            return itemName;
        }

        public string GetDescription() {
            return description;
        }

        public Sprite GetSprite() {
            return sprite;
        }

        public List<EffectCreator> GetEffects() {
            return effects;
        }

        public EffectCreator GetEffects(int index) {
            return effects[index];
        }

    #endregion

    #region Setters

        public void SetName(string itemName) {
            this.itemName = itemName;
        }

        public void SetDescription(string description) {
            this.description = description;
        }

        public void SetSprite(Sprite sprite) {
            this.sprite = sprite;
        }

        public void SetEffects(List<EffectCreator> effects) {
            this.effects = effects;
        }

    #endregion
}
