// Copyright (c) xxx, 2022. All rights reserved.


namespace App
{
    public class MetricsCollector :
    IProcessorMetricsCollector,
    IMemoryMetricsCollector,
    INetworkMetricsCollector
    {
        long INetworkMetricsCollector.GetThroughput() => PerformanceMetrics.Create().Network;

        int IProcessorMetricsCollector.GetUsage() => PerformanceMetrics.Create().Processor;

        long IMemoryMetricsCollector.GetUsage() => PerformanceMetrics.Create().Memory;
    }
}