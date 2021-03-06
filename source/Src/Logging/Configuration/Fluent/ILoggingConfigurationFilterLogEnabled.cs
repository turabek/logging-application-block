// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.


using Microsoft.Practices.EnterpriseLibrary.Logging.Filters;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Fluent
{
    /// <summary>
    /// Fluent interface used to configure a <see cref="LogEnabledFilter"/> instance.
    /// </summary>
    /// <see cref="LogEnabledFilter"/>
    /// <see cref="LogEnabledFilterData"/>
    public interface ILoggingConfigurationFilterLogEnabled : ILoggingConfigurationOptions, IFluentInterface
    {
        /// <summary>
        /// Specifies that all logging should be enabled. <br/>
        /// The default for the <see cref="LogEnabledFilter"/> is that all logging is disabled.
        /// </summary>
        /// <returns>Fluent interface used to further configure the logging application block.</returns>
        /// <see cref="LogEnabledFilter"/>
        /// <see cref="LogEnabledFilterData"/>
        ILoggingConfigurationOptions Enable();
    }
}
