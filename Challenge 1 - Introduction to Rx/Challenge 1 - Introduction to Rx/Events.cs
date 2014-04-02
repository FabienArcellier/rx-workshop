using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroductionToRx
{
    class Events
    {
        public event Action<string> TextChanged;
        private event Action<int> _myLengthChanged;

        public virtual void OnTextChanged(string text)
        {
            var t = TextChanged;
            if (t != null)
                t(text);

            if (_myLengthChanged != null)
                _myLengthChanged(text.Length);
        }

        public event Action<int> LengthChanged
        {
            add
            {
                _myLengthChanged += value;
            }
            remove
            {
                _myLengthChanged -= value;
            }
        }
    }
}
