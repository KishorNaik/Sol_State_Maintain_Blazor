using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.State
{
    public interface ICounterState
    {
        event Action onCountChanged; 
        int IncrementCount { get; set; }

        void IncrementCouter();
        
    }

    public class CounterState : ICounterState
    {
        public int IncrementCount { get; set; }

        public event Action onCountChanged;

        public void IncrementCouter()
        {
            IncrementCount++;
            onCountChanged?.Invoke();
        }
    }
}
