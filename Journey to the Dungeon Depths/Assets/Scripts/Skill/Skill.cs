using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skill", fileName = "obj_skill_")]
public class Skill : ScriptableObject {
    [SerializeField]private string skillName;
    [SerializeField,TextArea(3,10)]private string description;
    [SerializeField]private Sprite sprite;

    [SerializeField]private List<EffectCreator> effects = new List<EffectCreator>();

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
            return skillName;
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

        public void SetName(string skillName) {
            this.skillName = skillName;
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
