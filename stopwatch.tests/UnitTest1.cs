using System;
using Xunit;
using stopwatch;
using FluentAssertions;
using System.Threading;

namespace stopwatch.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Stopwatch_Start_throws_exception_when_started_again()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();    

            stopwatch.Invoking(x => x.Start()).Should()
                .Throw<NullReferenceException>()
                .WithMessage("Stopwatch is already running.");
        }

        [Fact]
        public void Stopwatch_Stop_throws_exception_if_not_running()
        {
            var stopwatch = new Stopwatch();

            stopwatch.Invoking(x => x.Stop()).Should()
                .Throw<NullReferenceException>()
                .WithMessage("Stopwatch is not running.");
        }
        
        [Fact]
        public void Stopwatch_Stop_outputs_time_elapsed()
        {
            var stopwatch = new Stopwatch();
            var controleWatch = new System.Diagnostics.Stopwatch();

            stopwatch.Start();
            controleWatch.Start();
            Thread.Sleep(200);

            var result = stopwatch.Stop();            
            controleWatch.Stop();

            result.Should().BeCloseTo(controleWatch.Elapsed, 1);
        }

        [Fact]
        public void Stopwatch_can_be_used_consecutively()
        {
            var stopwatch = new Stopwatch();
            var controleWatch = new System.Diagnostics.Stopwatch();

            stopwatch.Start();
            stopwatch.Stop();

            stopwatch.Start();
            controleWatch.Start();
            Thread.Sleep(200);

            var result = stopwatch.Stop();            
            controleWatch.Stop();

            result.Should().BeCloseTo(controleWatch.Elapsed, 1);
        }
    }
}
