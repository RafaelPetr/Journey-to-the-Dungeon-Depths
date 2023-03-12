using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skill", fileName = "obj_skill_")]
public class Skill : ScriptableObject {
    [SerializeField]private string skillName;
    [SerializeField,TextArea(3,10)]private string description;

    [SerializeField]private OffensiveComponent offComponent;
    [SerializeField]private List<EffectComponent> effComponents = new List<EffectComponent>();

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
            return skillName;
        }

        public string GetDescription() {
            return description;
        }

        public OffensiveComponent GetOffComponent() {
            return offComponent;
        }

        public List<EffectComponent> GetEffComponents() {
            return effComponents;
        }

        public EffectComponent GetEffComponents(int index) {
            return effComponents[index];
        }

    #endregion

    #region Setters

        public void SetName(string skillName) {
            this.skillName = skillName;
        }

        public void SetDescription(string description) {
            this.description = description;
        }

        public void SetOffComponent(OffensiveComponent offComponent) {
            this.offComponent = offComponent;
        }

        public void SetEffComponents(List<EffectComponent> effComponents) {
            this.effComponents = effComponents;
        }

    #endregion
}
