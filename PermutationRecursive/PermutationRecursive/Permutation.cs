using System.Collections.Generic;
using System.Linq;

namespace PermutationRecursive
{
    public class Permutation
    {
        public List<List<string>> Result { get; private set; } = new List<List<string>> { };

        public Permutation(List<string> source)
        {
            this._source = source;
            this._length = this._source.Count();

            var used = Enumerable.Range(0, this._length).Select(i => false).ToList();
            this._used.AddRange(used);

            var indexPermutation = Enumerable.Range(0, this._length).Select(i => 0).ToList();
            this._indexPermutation.AddRange(indexPermutation);

            CalcResult(0);
        }

        private void CalcResult(int n)
        {
            if (n == this._length)       // it's a solution
            {
                ResultAdd();
                return;
            }

            for (int i = 0; i < this._length; i++)
            {
                if (this._used[i] == false)
                {
                    this._used[i] = true;
                    this._indexPermutation[n] = i;

                    CalcResult(n + 1);

                    this._used[i] = false;
                }
            }
        }

        private void ResultAdd()
        {
            List<string> tmpResult = new List<string>();
            _indexPermutation.ForEach(i => {
                tmpResult.Add(this._source[i]);
            });
            Result.Add(tmpResult);
        }

        private List<bool> _used = new List<bool>();            // 記錄 index 是否使用過，用過為 true。
        private int _length;                                    // 此次排列組合資料的長度
        private List<int> _indexPermutation = new List<int>();  // 存放該次排列的 index 
        private List<string> _source;                           // 進行排列組合的原資料
    }
}
