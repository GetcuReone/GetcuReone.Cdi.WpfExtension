using GetcuReone.Cdi.MvvmFrameWpf.Entities;
using GetcuReone.FactFactory.BaseEntities;
using System;
using System.Windows.Controls;

namespace GetcuReone.Cdi.MvvmFrameWpf
{
    /// <summary>
    /// Helper for GetcuReone.Cdi.Wpf.
    /// </summary>
    public static class CdiWpfHelper
    {
        /// <summary>
        /// Create visibile scope.
        /// </summary>
        /// <param name="frame"></param>
        /// <returns></returns>
        public static IDisposable CreateVisibleScope(this Frame frame)
        {
            return new VisibleFrameScope(frame);
        }

        /// <summary>
        /// Copy container.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static void CopyTo<TFactContainerFrom, TFactContainerTo>(this TFactContainerFrom from, TFactContainerTo to)
            where TFactContainerFrom : FactContainerBase
            where TFactContainerTo : FactContainerBase
        {
            foreach (var fact in from)
                to.Add(fact);
        }
    }
}
