using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skill", fileName = "obj_skill_")]
public class Skill : ScriptableObject {
    [SerializeField]private string skillName;
    [SerializeField,TextArea(3,10)]private string description;

    [SerializeField]private OffensiveComponent offComponent = new OffensiveComponent();
    [SerializeField]private List<EffectComponent> effComponents = new List<EffectComponent>();

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

        public List<EffectComponent> GetEffComponent() {
            return effComponents;
        }

        public EffectComponent GetEffComponent(int index) {
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

        public void SetOffensive(OffensiveComponent offComponent) {
            this.offComponent = offComponent;
        }

        public void SetEffectComponents(List<EffectComponent> effComponents) {
            this.effComponents = effComponents;
        }

    #endregion
}
