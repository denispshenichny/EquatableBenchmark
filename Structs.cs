using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquatableBenchmark {
    public struct S {
        public int Value;
        public int Value1;
        public int Value2;
        public int Value3;

        public S(int value) {
            Value = value;
            Value1 = value;
            Value2 = value;
            Value3 = value;
        }

        public override bool Equals(object obj) {
            return obj is S s &&
                   Value == s.Value &&
                   Value1 == s.Value1 &&
                   Value2 == s.Value2 &&
                   Value3 == s.Value3;
        }
        public override int GetHashCode() => Value;
    }

    public struct S_Imp : IEquatable<S_Imp> {
        public int Value;
        public int Value1;
        public int Value2;
        public int Value3;

        public S_Imp(int value) {
            Value = value;
            Value1 = value;
            Value2 = value;
            Value3 = value;
        }

        public override bool Equals(object obj) {
            return obj is S_Imp other && Equals(other);
        }
        public override int GetHashCode() => Value;

        public bool Equals(S_Imp other) {
            return Value == other.Value && Value1 == other.Value1 && Value2 == other.Value2 && Value3 == other.Value3;
        }

        public static bool operator ==(S_Imp left, S_Imp right) {
            return left.Equals(right);
        }

        public static bool operator !=(S_Imp left, S_Imp right) {
            return !(left == right);
        }
    }

    public struct S_Exp : IEquatable<S_Exp> {
        public int Value;
        public int Value1;
        public int Value2;
        public int Value3;

        public S_Exp(int value) {
            Value = value;
            Value1 = value;
            Value2 = value;
            Value3 = value;
        }

        public override bool Equals(object obj) {
            return obj is S_Exp other && ((IEquatable<S_Exp>)this).Equals(other);
        }
        public override int GetHashCode() => Value;

        bool IEquatable<S_Exp>.Equals(S_Exp other) {
            return Value == other.Value && Value1 == other.Value1 && Value2 == other.Value2 && Value3 == other.Value3;
        }

        public static bool operator ==(S_Exp left, S_Exp right) {
            return left.Equals(right);
        }

        public static bool operator !=(S_Exp left, S_Exp right) {
            return !(left == right);
        }
    }
}
