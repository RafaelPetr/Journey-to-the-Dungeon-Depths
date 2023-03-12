using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item", fileName = "obj_item_")]
public class Item : ScriptableObject {
    [SerializeField]protected string itemName;
    [SerializeField,TextArea(3,10)]protected string description;

    [SerializeField]protected Sprite sprite;
    [SerializeField]protected List<EffectComponent> effComponents = new List<EffectComponent>();

    public virtual void Use() {}

    #region Add

        public void AddEffComponent(EffectComponent effComponent) {
            effComponents.Add(effComponent);
        }

    #endregion

    #region Remove

        public void RemoveEffComponent(EffectComponent effComponent) {
            effComponents.Remove(effComponent);
        }

        public void RemoveEffComponent(int index) {
            effComponents.RemoveAt(index);
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

        public List<EffectComponent> GetEffComponents() {
            return effComponents;
        }

        public EffectComponent GetEffComponents(int index) {
            return effComponents[index];
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

        public void SetEffDescriptions(List<EffectComponent> effComponents) {
            this.effComponents = effComponents;
        }

    #endregion
}
