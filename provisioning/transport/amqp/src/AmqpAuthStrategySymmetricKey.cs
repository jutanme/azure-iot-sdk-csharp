﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Azure.Amqp;
using Microsoft.Azure.Amqp.Sasl;
using Microsoft.Azure.Devices.Shared;
using Microsoft.Azure.Devices.Provisioning.Client.Transport.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Devices.Provisioning.Client.Transport
{
    internal class AmqpAuthStrategySymmetricKey : AmqpAuthStrategy
    {
        private SecurityProviderSymmetricKey _security;

        public AmqpAuthStrategySymmetricKey(SecurityProviderSymmetricKey security)
        {
            _security = security;
        }

        public override AmqpSettings CreateAmqpSettings(string idScope)
        {
            var settings = new AmqpSettings();

            var saslProvider = new SaslTransportProvider();
            saslProvider.Versions.Add(AmqpConstants.DefaultProtocolVersion);
            settings.TransportProviders.Add(saslProvider);

            SaslPlainHandler saslHandler = new SaslPlainHandler();
            saslHandler.AuthenticationIdentity = $"{idScope}/registrations/{_security.GetRegistrationID()}";
            string key = _security.GetPrimaryKey();
            saslHandler.Password = ProvisioningSasBuilder.BuildSasSignature("registration", key, saslHandler.AuthenticationIdentity, TimeSpan.FromDays(1));
            saslProvider.AddHandler(saslHandler);

            return settings;
        }

        public override Task OpenConnectionAsync(AmqpClientConnection connection, TimeSpan timeout, bool useWebSocket, IWebProxy proxy)
        {
            return connection.OpenAsync(timeout, useWebSocket, null, proxy);
        }

        public override void SaveCredentials(RegistrationOperationStatus operation)
        {
            
        }
    }
}