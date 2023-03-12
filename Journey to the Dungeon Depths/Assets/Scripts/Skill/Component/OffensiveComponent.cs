using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OffensiveComponent : SkillComponent {
    private DamageType damageType;
    private int damagePercent;

    #region Getters

        public int GetDamagePercent() {
            return damagePercent;
        }

        public DamageType GetDamageType() {
            return damageType;
        }

    #endregion

    #region Setters

        public void SetDamagePercent(int damagePercent) {
            this.damagePercent = damagePercent;
        }

        public void SetDamageType(DamageType damageType) {
            this.damageType = damageType;
        }

    #endregion
}