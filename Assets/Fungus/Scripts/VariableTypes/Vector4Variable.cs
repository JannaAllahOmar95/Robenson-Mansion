// This code is part of the Fungus library (https://github.com/snozbot/fungus)
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)

/*This script has been, partially or completely, generated by the Fungus.GenerateVariableWindow*/

using UnityEngine;

namespace Fungus
{
    /// <summary>
    /// Vector4 variable type.
    /// </summary>
    [VariableInfo("Other", "Vector4")]
    [AddComponentMenu("")]
    [System.Serializable]
    public class Vector4Variable : VariableBase<UnityEngine.Vector4>
    {
        public override bool IsArithmeticSupported(SetOperator setOperator)
        {
            return true;
        }

        public override void Apply(SetOperator setOperator, Vector4 value)
        {
            Vector4 local = Value;

            switch (setOperator)
            {
                case SetOperator.Negate:
                    Value = Value * -1;
                    break;

                case SetOperator.Add:
                    Value += value;
                    break;

                case SetOperator.Subtract:
                    Value -= value;
                    break;

                case SetOperator.Multiply:
                    local.Scale(value);
                    Value = local;
                    break;

                case SetOperator.Divide:
                    local.Scale(new Vector4(1.0f / value.x, 1.0f / value.y, 1.0f / value.z, 1.0f / value.w));
                    Value = local;
                    break;

                default:
                    base.Apply(setOperator, value);
                    break;
            }
        }
    }

    /// <summary>
    /// Container for a Vector4 variable reference or constant value.
    /// </summary>
    [System.Serializable]
    public struct Vector4Data
    {
        [SerializeField]
        [VariableProperty("<Value>", typeof(Vector4Variable))]
        public Vector4Variable vector4Ref;

        [SerializeField]
        public UnityEngine.Vector4 vector4Val;

        public static implicit operator UnityEngine.Vector4(Vector4Data Vector4Data)
        {
            return Vector4Data.Value;
        }

        public Vector4Data(UnityEngine.Vector4 v)
        {
            vector4Val = v;
            vector4Ref = null;
        }

        public UnityEngine.Vector4 Value
        {
            get { return (vector4Ref == null) ? vector4Val : vector4Ref.Value; }
            set { if (vector4Ref == null) { vector4Val = value; } else { vector4Ref.Value = value; } }
        }

        public string GetDescription()
        {
            if (vector4Ref == null)
            {
                return vector4Val.ToString();
            }
            else
            {
                return vector4Ref.Key;
            }
        }
    }
}