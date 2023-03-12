using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkillComponent {
    protected TargetType targetType;
    protected int numberTargets;
    protected bool isRandom;

    #region Getters

        public TargetType GetTargetType() {
            return targetType;
        }

        public int GetNumberTargets() {
            return numberTargets;
        }

        public bool GetIsRandom() {
            return isRandom;
        }

    #endregion

    #region Setters

        public void SetTargetType(TargetType targetType) {
            this.targetType = targetType;
        } 

        public void SetNumberTargets(int numberTargets) {
            this.numberTargets = numberTargets;
        }

        public void SetIsRandom(bool isRandom) {
            this.isRandom = isRandom;
        }

    #endregion
}
