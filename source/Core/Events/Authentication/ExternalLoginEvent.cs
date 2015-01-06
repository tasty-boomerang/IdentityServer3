﻿/*
 * Copyright 2014, 2015 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Thinktecture.IdentityServer.Core.Events
{
    /// <summary>
    /// Event class for external login events
    /// </summary>
    public class ExternalLoginEvent : AuthenticationEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalLoginEvent"/> class.
        /// </summary>
        /// <param name="type">Event type.</param>
        public ExternalLoginEvent(EventTypes type)
            : base(EventConstants.Ids.ExternalLogin, type)
        {
            if (type == EventTypes.Success)
            {
                Message = Resources.Events.ExternalLoginSuccess;
            }
            else if (type == EventTypes.Failure)
            {
                Message = Resources.Events.ExternalLoginFailure;
            }
            else
            {
                Message = "External login event";
            }
        }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the provider identifier.
        /// </summary>
        /// <value>
        /// The provider identifier.
        /// </value>
        public string ProviderId { get; set; }
    }
}