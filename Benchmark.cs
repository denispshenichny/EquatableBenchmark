using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace EquatableBenchmark {
    public class Benchmark {
        List<S_Imp> listImp;
        List<S_Exp> listExp;
        List<S> list;
        [GlobalSetup]
        public void Setup() {
            listImp = new List<S_Imp>(10_000_000);
            listExp = new List<S_Exp>(10_000_000);
            list = new List<S>(10_000_000);

            for (int i = 0; i < listImp.Capacity; i++) {
                listImp.Add(new S_Imp(i));
                listExp.Add(new S_Exp(i));
                list.Add(new S(i));
            }
        }

        [Benchmark]
        public void ContainsImp() {
            bool x = listImp.Contains(new S_Imp(listImp.Capacity - 1));
            bool x_ = listImp.Contains(new S_Imp(listImp.Capacity));
            if (!x || x_)
                throw new Exception();
        }
        [Benchmark]
        public void ContainsExp() {
            bool x = listExp.Contains(new S_Exp(listExp.Capacity - 1));
            bool x_ = listExp.Contains(new S_Exp(listExp.Capacity));
            if (!x || x_)
                throw new Exception();
        }
        [Benchmark]
        public void ContainsDef() {
            bool x = list.Contains(new S(list.Capacity - 1));
            bool x_ = list.Contains(new S(list.Capacity));
            if (!x || x_)
                throw new Exception();
        }

        [Benchmark]
        public void OperatorImp() {
            int idx = listImp.FindIndex(x => x == new S_Imp(listImp.Capacity - 1));
            int idx_ = listImp.FindIndex(x => x == new S_Imp(listImp.Capacity));
            if (idx < 0 || idx_ >= 0)
                throw new Exception();
        }
        [Benchmark]
        public void OperatorExp() {
            int idx = listExp.FindIndex(x => x == new S_Exp(listImp.Capacity - 1));
            int idx_ = listExp.FindIndex(x => x == new S_Exp(listImp.Capacity));
            if (idx < 0 || idx_ >= 0)
                throw new Exception();
        }
    }
}
