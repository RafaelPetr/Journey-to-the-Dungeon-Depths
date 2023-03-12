using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect {
    [SerializeField]protected EffectType type;
    [SerializeField]protected bool isPositive, isPermanent;
    [SerializeField]protected int duration;

    //Each effect will append to a different GameManager Event?

    public abstract void Execute();

    #region Getters

        public EffectType GetEffectType() {
            return type;
        }

        public bool GetIsPositive() {
            return isPositive;
        }

        public bool GetIsPermanent() {
            return isPermanent;
        }

        public int GetDuration() {
            return duration;
        }

    #endregion

    #region Setters

        public void SetEffectType(EffectType type) {
            this.type = type;
        }

        public void SetIsPositive(bool isPositive) {
            this.isPositive = isPositive;
        }

        public void SetIsPermanent(bool isPermanent) {
            this.isPermanent = isPermanent;
        }

        public void SetDuration(int duration) {
            this.duration = duration;
        }

    #endregion
}
