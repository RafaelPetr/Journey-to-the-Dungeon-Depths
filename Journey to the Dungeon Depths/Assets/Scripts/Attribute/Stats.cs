using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Stats", fileName = "obj_stats_")]
public class Stats : ScriptableObject {
    [SerializeField]private Attribute hp;
    [SerializeField]private Attribute sp;
    [SerializeField]private Attribute atk;
    [SerializeField]private Attribute mag;
    [SerializeField]private Attribute def;
    [SerializeField]private Attribute magDef;
    [SerializeField]private Attribute agi;

    [SerializeField]private DamageType damageType;
    [SerializeField]private Attribute fireRes, lightningRes, iceRes;

    [SerializeField]private bool hasDifficulty;
    [SerializeField]private Difficulty difficulty;

    #region Getters

        public bool GetHasDifficulty() {
            return hasDifficulty;
        }

        public Difficulty GetDifficulty() {
            return difficulty;
        }

        public Attribute GetHp() {
            return hp;
        }

        public Attribute GetSp() {
            return sp;
        }

        public Attribute GetAtk() {
            return atk;
        }

        public Attribute GetMag() {
            return mag;
        }

        public Attribute GetDef() {
            return def;
        }

        public Attribute GetMagDef() {
            return magDef;
        }

        public Attribute GetAgi() {
            return agi;
        }

        public Attribute GetFireRes() {
            return fireRes;
        }

        public Attribute GetLightningRes() {
            return lightningRes;
        }

        public Attribute GetIceRes() {
            return iceRes;
        }

        public DamageType GetDamageType() {
            return damageType;
        }

    #endregion

    #region Setters

        public void SetHasDifficulty(bool hasDifficulty) {
            this.hasDifficulty = hasDifficulty;
        }

        public void SetDifficulty(Difficulty difficulty) {
            this.difficulty = difficulty;
        }

        public void SetHp(int hp) {
            this.hp.SetValue(hp);
        }

        public void SetHp(AttributeGrowthType growthType) {
            this.hp.SetLevelType(growthType);
        }

        public void SetSp(int sp) {
            this.sp.SetValue(sp);
        }

        public void SetSp(AttributeGrowthType growthType) {
            this.sp.SetLevelType(growthType);
        }

        public void SetAtk(int atk) {
            this.atk.SetValue(atk);
        }

        public void SetAtk(AttributeGrowthType growthType) {
            this.atk.SetLevelType(growthType);
        }

        public void SetMag(int mag) {
            this.mag.SetValue(mag);
        }

        public void SetMag(AttributeGrowthType growthType) {
            this.mag.SetLevelType(growthType);
        }

        public void SetDef(int def) {
            this.def.SetValue(def);
        }

        public void SetDef(AttributeGrowthType growthType) {
            this.def.SetLevelType(growthType);
        }

        public void SetMagDef(int magDef) {
            this.magDef.SetValue(magDef);
        }

        public void SetMagDef(AttributeGrowthType growthType) {
            this.magDef.SetLevelType(growthType);
        }

        public void SetAgi(int agi) {
            this.agi.SetValue(agi);
        }

        public void SetAgi(AttributeGrowthType growthType) {
            this.agi.SetLevelType(growthType);
        }

        public void SetFireRes(int fireRes) {
            this.fireRes.SetValue(fireRes);
        }

        public void SetLightningRes(int lightningRes) {
            this.lightningRes.SetValue(lightningRes);
        }

        public void SetIceRes(int iceRes) {
            this.iceRes.SetValue(iceRes);
        }

        public void SetDamageType(DamageType damageType) {
            this.damageType = damageType;
        }

    #endregion
}
