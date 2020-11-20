using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetcuReone.Cdi.WpfEntities
{
    /// <summary>
    /// Object to wait.
    /// </summary>
    public class Awaiter
    {
        private readonly int _waitStep;
        private readonly List<Awaiter> _child = new List<Awaiter>();

        /// <summary>
        /// Finished.
        /// </summary>
        public bool Finished { get; private set; } = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="waitStep"></param>
        public Awaiter(int waitStep = 100)
        {
            _waitStep = waitStep;
        }

        /// <summary>
        /// Finish.
        /// </summary>
        public void Finish() => Finished = true;

        /// <summary>
        /// Add child <see cref="Awaiter"/>.
        /// </summary>
        /// <param name="awaiter"></param>
        public void AddChild(Awaiter awaiter) => _child.Add(awaiter);

        /// <summary>
        /// wait for the end.
        /// </summary>
        /// <returns></returns>
        public async ValueTask WaitFinishAsync()
        {
            while (!Finished)
                await Task.Delay(_waitStep).ConfigureAwait(false);

            foreach (var item in _child)
                while (!item.Finished)
                    await Task.Delay(_waitStep).ConfigureAwait(false);
        }
    }
}
