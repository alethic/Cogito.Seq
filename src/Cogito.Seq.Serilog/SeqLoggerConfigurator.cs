﻿using System;

using Cogito.Serilog;

using Microsoft.Extensions.Options;

using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace Cogito.Seq.Serilog
{

    /// <summary>
    /// Configures Serilog to send logs to Seq.
    /// </summary>
    public class SeqLoggerConfigurator : ILoggerConfigurator
    {

        readonly IOptions<SeqOptions> options;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="options"></param>
        public SeqLoggerConfigurator(IOptions<SeqOptions> options)
        {
            this.options = options ?? throw new ArgumentNullException(nameof(options));
        }

        public LoggerConfiguration Apply(LoggerConfiguration configuration)
        {
            if (options.Value != null && !string.IsNullOrEmpty(options.Value.ServerUrl))
            {
                var apiKey = options.Value.ApiKey;
                if (string.IsNullOrWhiteSpace(apiKey))
                    apiKey = null;

                var controlLevelSwitch = new LoggingLevelSwitch(LogEventLevel.Verbose);
                configuration = configuration.MinimumLevel.ControlledBy(controlLevelSwitch);
                return configuration.WriteTo.Seq(options.Value.ServerUrl, apiKey: apiKey, controlLevelSwitch: controlLevelSwitch);
            }

            return configuration;
        }

    }

}
