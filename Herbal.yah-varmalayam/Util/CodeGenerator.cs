using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbal.yah_varmalayam
{
    public static class CodeGenerator
    {
        private static readonly char _minChar = 'A';
        private static readonly char _maxChar = 'C';
        private static readonly int _minDigit = 1;
        private static readonly int _maxDigit = 5;
        private static int _fixedLength = 5;//zero means variable length
        private static int _currentDigit = 1;
        private static string _currentBase = "A";

        public static string NextID()
        {
            if (_currentBase[_currentBase.Length - 1] <= _maxChar)
            {
                if (_currentDigit <= _maxDigit)
                {
                    var result = string.Empty;
                    if (_fixedLength > 0)
                    {
                        var prefixZeroCount = _fixedLength - _currentBase.Length;
                        if (prefixZeroCount < _currentDigit.ToString().Length)
                            throw new InvalidOperationException("The maximum length possible has been exeeded.");
                        result = result = _currentBase + _currentDigit.ToString("D" + prefixZeroCount.ToString());
                    }
                    else
                    {
                        result = _currentBase + _currentDigit.ToString();
                    }
                    _currentDigit++;
                    return result;
                }
                else
                {
                    _currentDigit = _minDigit;
                    if (_currentBase[_currentBase.Length - 1] == _maxChar)
                    {
                        _currentBase = _currentBase.Remove(_currentBase.Length - 1) + _minChar;
                        _currentBase += _minChar.ToString();
                    }
                    else
                    {
                        var newChar = _currentBase[_currentBase.Length - 1];
                        newChar++;
                        _currentBase = _currentBase.Remove(_currentBase.Length - 1) + newChar.ToString();
                    }

                    return NextID();
                }
            }
            else
            {
                _currentDigit = _minDigit;
                _currentBase += _minChar.ToString();
                return NextID();

            }
        }

        public static string NextID(string currentId)
        {
            if (string.IsNullOrWhiteSpace(currentId))
                return NextID();

            var charCount = currentId.Length;
            var indexFound = -1;
            for (int i = 0; i < charCount; i++)
            {
                if (!char.IsNumber(currentId[i]))
                    continue;

                indexFound = i;
                break;
            }
            if (indexFound > -1)
            {
                _currentBase = currentId.Substring(0, indexFound);
                _currentDigit = int.Parse(currentId.Substring(indexFound)) + 1;
            }
            return NextID();
        }
    }
}
