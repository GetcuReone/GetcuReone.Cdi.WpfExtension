using GetcuReone.Cdi.MvvmFrameWpf.Entities;
using GetcuReone.FactFactory.BaseEntities;
using GetcuReone.FactFactory.Interfaces;
using GetcuReone.MvvmFrame.Wpf.Commands;
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

        /// <summary>
        /// Update and remove fact.
        /// </summary>
        /// <typeparam name="TFact"></typeparam>
        /// <typeparam name="TFactContainer"></typeparam>
        /// <param name="container"></param>
        /// <param name="fact"></param>
        /// <param name="args"></param>
        public static void TryUpdateAndRemoveFact<TFactContainer, TFact>(this TFactContainer container, TFact fact, CommandArgs args)
            where TFactContainer : IFactContainer
            where TFact : IFact
        {
            container.UpdateFact(fact);

            args.AddFinalOperation(() =>
            {
                TFact innerFact = fact;
                var innerContainer = container;

                innerContainer.Remove(innerFact);
            });
        }

        /// <summary>
        /// Update and remove fact.
        /// </summary>
        /// <typeparam name="TFact"></typeparam>
        /// <typeparam name="TFactContainer"></typeparam>
        /// <param name="container"></param>
        /// <param name="fact"></param>
        /// <param name="args"></param>
        public static void TryUpdateAndRemoveFact<TFactContainer, TFact>(this TFactContainer container, TFact fact, AsyncCommandArgs args)
            where TFactContainer : IFactContainer
            where TFact : IFact
        {
            container.UpdateFact(fact);

            args.AddFinalOperation(() =>
            {
                TFact innerFact = fact;
                var innerContainer = container;

                innerContainer.Remove(innerFact);
            });
        }
    }
}
