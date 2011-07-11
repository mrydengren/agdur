﻿using System.Linq;
using Agdur.Abstractions;
using Agdur.Internals;

namespace Agdur
{
    public static class BenchmarkBuilderWithSyntaxExtensions
    {
        /// <summary>
        /// Specifies that the average value should be calculated.
        /// </summary>
        public static IBenchmarkBuilderInSyntax<IBenchmarkBuilderContinutation> Average(this IBenchmarkBuilderWithSyntax<IBenchmarkBuilderContinutation> builder)
        {
            return builder.Custom("average", data => data.Average());
        }

        /// <summary>
        /// Specifies that the first number of specified samples should be displayed.
        /// </summary>
        /// <param name="numberOfSamples">The number of samples that should be displayed.</param>
        public static IBenchmarkBuilderInSyntax<IBenchmarkBuilderContinutation> First(this IBenchmarkBuilderWithSyntax<IBenchmarkBuilderContinutation> builder, int numberOfSamples)
        {
            Ensure.GreaterThanZero(numberOfSamples, "numberOfSamples");
            return builder.Custom("first", data => data.Take(numberOfSamples));
        }

        /// <summary>
        /// Specifies that the maximum value should be calculated.
        /// </summary>
        public static IBenchmarkBuilderInSyntax<IBenchmarkBuilderContinutation> Max(this IBenchmarkBuilderWithSyntax<IBenchmarkBuilderContinutation> builder)
        {
            return builder.Custom("maximum", data => data.Max());
        }

        /// <summary>
        /// Specifies that the minimum value should be calculated.
        /// </summary>
        public static IBenchmarkBuilderInSyntax<IBenchmarkBuilderContinutation> Min(this IBenchmarkBuilderWithSyntax<IBenchmarkBuilderContinutation> builder)
        {
            return builder.Custom("minimum", data => data.Min());
        }

        /// <summary>
        /// Specifies that the total value should be calculated.
        /// </summary>
        public static IBenchmarkBuilderInSyntax<IBenchmarkBuilderContinutation> Total(this IBenchmarkBuilderWithSyntax<IBenchmarkBuilderContinutation> builder)
        {
            return builder.Custom("total", data => data.Sum());
        }
    }
}