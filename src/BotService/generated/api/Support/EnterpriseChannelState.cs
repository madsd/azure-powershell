// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Support
{

    /// <summary>The current state of the Enterprise Channel.</summary>
    public partial struct EnterpriseChannelState :
        System.IEquatable<EnterpriseChannelState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState CreateFailed = @"CreateFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState DeleteFailed = @"DeleteFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState StartFailed = @"StartFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState Started = @"Started";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState Starting = @"Starting";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState StopFailed = @"StopFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState Stopped = @"Stopped";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState Stopping = @"Stopping";

        /// <summary>the value for an instance of the <see cref="EnterpriseChannelState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to EnterpriseChannelState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EnterpriseChannelState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new EnterpriseChannelState(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="EnterpriseChannelState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private EnterpriseChannelState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type EnterpriseChannelState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type EnterpriseChannelState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is EnterpriseChannelState && Equals((EnterpriseChannelState)obj);
        }

        /// <summary>Returns hashCode for enum EnterpriseChannelState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for EnterpriseChannelState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to EnterpriseChannelState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EnterpriseChannelState" />.</param>

        public static implicit operator EnterpriseChannelState(string value)
        {
            return new EnterpriseChannelState(value);
        }

        /// <summary>Implicit operator to convert EnterpriseChannelState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="EnterpriseChannelState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum EnterpriseChannelState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState e1, Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum EnterpriseChannelState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState e1, Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.EnterpriseChannelState e2)
        {
            return e2.Equals(e1);
        }
    }
}