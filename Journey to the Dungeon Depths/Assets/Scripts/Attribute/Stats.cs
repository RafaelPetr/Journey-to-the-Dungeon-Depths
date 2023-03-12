using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Stats", fileName = "obj_stats_")]
public class Stats : ScriptableObject {
    [SerializeField]private Attribute hp;
    [SerializeField]private Attribute sp;
    [SerializeField]private Attribute atk;
    [SerializeField]private Attribute mag;
    [SerializeField]private Attribute agi;
    [SerializeField]private Attribute luk;

    [SerializeField]private DamageType damageType;
    [SerializeField]private Attribute physicalRes, fireRes, lightningRes, waterRes;

    #region Getters

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

        public Attribute GetAgi() {
            return agi;
        }

        public Attribute GetLuk() {
            return luk;
        }

        public Attribute GetPhysicalRes() {
            return physicalRes;
        }

        public Attribute GetFireRes() {
            return fireRes;
        }

        public Attribute GetLightningRes() {
            return lightningRes;
        }

        public Attribute GetWaterRes() {
            return waterRes;
        }

        public DamageType GetDamageType() {
            return damageType;
        }

    #endregion

    #region Setters

        public void SetHp(int hp) {
            this.hp.SetValue(hp);
        }

        public void SetSp(int sp) {
            this.sp.SetValue(sp);
        }

        public void SetAtk(int atk) {
            this.atk.SetValue(atk);
        }

        public void SetMag(int mag) {
            this.mag.SetValue(mag);
        }

        public void SetAgi(int agi) {
            this.agi.SetValue(agi);
        }

        public void SetLuk(int luk) {
            this.luk.SetValue(luk);
        }

        public void SetPhysRes(int physRes) {
            this.physicalRes.SetValue(physRes);
        }

        public void SetFireRes(int fireRes) {
            this.fireRes.SetValue(fireRes);
        }

        public void SetLightningRes(int lightningRes) {
            this.lightningRes.SetValue(lightningRes);
        }

        public void SetWaterRes(int waterRes) {
            this.waterRes.SetValue(waterRes);
        }

        public void SetDamageType(DamageType damageType) {
            this.damageType = damageType;
        }

    #endregion
}
