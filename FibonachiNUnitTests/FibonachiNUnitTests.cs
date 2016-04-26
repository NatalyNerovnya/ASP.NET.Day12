using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibonachiNumbers;
using NUnit.Framework;

namespace FibonachiNUnitTests
{
    public class FibonachiNUnitTests
    {
        #region Series tests
        public IEnumerable<TestCaseData> GetFibonachiSeriesCaseDatas
        {
            get
            {
                yield return new TestCaseData(4).Returns(new long[] { 0, 1, 1, 2 });
                yield return new TestCaseData(7).Returns(new long[] { 0, 1, 1, 2, 3, 5, 8 });
            }
        }

        [Test, TestCaseSource(nameof(GetFibonachiSeriesCaseDatas))]
        public IEnumerable<long> FibonachiSeriesTest(int n)
        {
            return Fibonachi.GetFibonachiSeries(n);
        }
        #endregion

        #region Get by index tests
        public IEnumerable<TestCaseData> GetFibonachiByIndexCaseDatas
        {
            get
            {
                yield return new TestCaseData(4).Returns(2);
                yield return new TestCaseData(7).Returns(8);
            }
        }

        [Test, TestCaseSource(nameof(GetFibonachiByIndexCaseDatas))]
        public long FibonachiByIndexTest(int n)
        {
            return Fibonachi.GetFibonachiByIndex(n);
        }
        #endregion
    }
}

