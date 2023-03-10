using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetType {Self, Any, All, SingleOther, AnyOther, AllOther}

public enum EffectType {Attribute, Immunity, Condition}

public enum DamageType {Physical, Water, Lightning, Fire, Neutral}

public enum ConditionType {Burn, Poison, Confusion, Paralysis, Freeze, Sleep, Stun}

public enum AttributeType {Hp, Sp, Atk, Mag, Def, WaterRes, LightningRes, FireRes, Agi, Luk}

public enum AttributeModifierType {Add, Multiplier, Percent}

public static class EnumController {
    public static int ConvertAttribute(Character character, AttributeType type) {
        switch (type) {
            case AttributeType.Hp:
                //return character.GetAttributes().GetHp();
                return 0;
            default:
                return -1;
        }
    }

    public static ConditionEffect ConvertCondition(ConditionEffect condition, ConditionType type) {
        switch (type) { //switch (condition.GetType()) {
            case ConditionType.Poison:
                return new Poison(condition.duration);
            default:
                return null;
        }
    }
}
