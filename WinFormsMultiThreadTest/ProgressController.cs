using System;
using System.Threading.Tasks;

namespace WinFormsMultiThreadTest
{
    /// <summary>
    /// Controls the progress.
    /// </summary>
    public class ProgressController
    {
        /// <summary>
        /// Called after each step is completed.
        /// </summary>
        public event Action<int> OnCompleteStep;    

        /// <summary>
        /// Progress the task.
        /// </summary>
        /// <param name="minInclusive"></param>
        /// <param name="maxExclusive"></param>
        /// <param name="delay"></param>
        /// <returns></returns>
        public async Task Progress(int minInclusive, int maxExclusive, int delay = 100)
        {
            for (int i = minInclusive; i < maxExclusive; i++)
            {
                await Task.Delay(delay);
                OnCompleteStep?.Invoke(i);
            }
        }
    }
}
